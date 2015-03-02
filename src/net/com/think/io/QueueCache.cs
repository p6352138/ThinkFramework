using System;
using System.IO;
using Thrift.Protocol;
using Thrift.Transport;
using System.Collections.Generic;

namespace com.think.io
{
    sealed public class QueueCache
    {
        private QueueCache()
        {
        }
        public static readonly QueueCache instance = new QueueCache();

        public bool IsDebug { get; set; }

        /// <summary>
        /// 是否重复发送数据
        /// </summary>
        public bool IsMulti { get; set; }

        int _multiCount = 10;
        public int MultiCount { get { return _multiCount; } set { _multiCount = value; } }

        public IAdapter Adapter { get; set; }

        int mSessionId = 0;
        public int SessionId
        {
            get
            {
                return mSessionId;
            }
            set
            {
                mSessionId = value;
            }
        }

        Queue<ResponseWrapper> responseQueue = new Queue<ResponseWrapper>();
        Queue<RequestWrapper> requestQueue = new Queue<RequestWrapper>();

		public void sendRequest(RequestWrapper rw)
		{
            sendRequest(rw, true);
		}

        /// <summary>
        /// 发送请求
        /// </summary>
        /// <param name="rw">消息内容</param>
        /// <param name="checkLoading">是否检查联网</param>
        public void sendRequest(RequestWrapper rw, bool checkLoading)
        {
            if (checkLoading)
            {
                System.Reflection.PropertyInfo pi = rw.request.GetType().GetProperty("Type");
                byte type = 99;
                if (pi != null)
                {
                    object obj = pi.GetValue(rw.request, null);
                    type = (byte)obj;
                }

                com.think.data.cache.lockscene.LockSceneItem lsi = com.think.data.cache.lockscene.LockSceneManager.instance.GetLockSceneItem(rw.requestType, type);
                if (lsi != null)
                {
                    com.think.manager.ISceneManager.Instance.SceneManager.AddLockScene(lsi);
                }
            }
            
            enqueueRequest(rw);
        }

        public void addHeartRequest()
        {
            RequestWrapper rw = new RequestWrapper();
            rw.requestType = 1;
            rw.request = new com.ireadygo.wr.framework.messages.HeartBeatRequest();

            enqueueRequest(rw);
        }

        void enqueueRequest(RequestWrapper request)
        {
            if (IsDebug)
            {
                Logger.Warning("request=" + request + " / " + TFUtils.getCurrentTime());
            }

            requestQueue.Enqueue(request);
            if (SocketClient.instance.IsConnected && !SocketClient.instance.IsSending)
            {
                SocketClient.instance.BeginSendData();
            }
            else if (!SocketClient.instance.IsConnected)
            {
                SocketClient.instance.BeginConnect();
            }
        }

        void enqueueResponse(ResponseWrapper response)
        {
            if (IsDebug)
            {
                Logger.Warning("response=" + response + " / " + Adapter + " / "+ TFUtils.getCurrentTime());
            } 
            responseQueue.Enqueue(response);

            if (Adapter != null)
            {
                Adapter.adapterTBase(response.responseType);
            }
        }

        public void reset()
        {
            mSessionId = 0;
            requestQueue.Clear();
            responseQueue.Clear();
        }

        public ResponseWrapper dequeue()
        {
            if (responseQueue.Count > 0)
            {
                return responseQueue.Dequeue();
            }
            return null;
        }

        public List<ResponseWrapper> GetResponse(byte msgType)
        {
            if (responseQueue.Count > 0)
            {
                ResponseWrapper[] rws = responseQueue.ToArray();
                List<ResponseWrapper> outs = new List<ResponseWrapper>();
                Queue<ResponseWrapper> newResponseQueue = new Queue<ResponseWrapper>();
                int length = rws.Length;
                for (int i = length - 1; i >= 0; i--)
                {
                    if (IsDebug)
                    {
                        Logger.Warning("response=" + rws[i] + " / " + Adapter + " / " + TFUtils.getCurrentTime());
                    }
                    if (rws[i].responseType == msgType)
                    {
                        outs.Insert(0,rws[i]);
                    }
                    else
                    {
                        newResponseQueue.Enqueue(rws[i]);
                    }
                }

                responseQueue.Clear();
                responseQueue = newResponseQueue;
                return outs;
            }
            return null;
        }

        #region code / decode
        public void decode(byte[] array)
        {
            using (MemoryStream stream = new MemoryStream(array))
            {
                short frameLength = Util.byteArray2Short(new byte[] { (byte)stream.ReadByte(), (byte)stream.ReadByte() });
                if (frameLength > 2)
                {
                    byte count = (byte)stream.ReadByte();
                    if (IsDebug)
                    {
                        Logger.Log("decode:::pacakge's size=" + count + "/" + TFUtils.getCurrentTime());
                    }
                    for (int i = 0; i < count; i++)
                    {
                        byte requestType = (byte)stream.ReadByte();
                        short l = Util.byteArray2Short(new byte[] { (byte)stream.ReadByte(), (byte)stream.ReadByte() });
                        byte[] body = new byte[l];
                        stream.Read(body, 0, l);

                        TBase tb = deserialize(body, requestType);
                        if (tb != null)
                        {
                            ResponseWrapper resp = new ResponseWrapper();
                            resp.responseType = requestType;
                            resp.response = tb;

                            enqueueResponse(resp);
                        }
                    }
                }
            }
        }

        public byte[] encode()
        {
            if (!IsMulti)
            {
                int count = requestQueue.Count;
                if (count > 0)
                {
                    var ms = new MemoryStream();

                    //length
                    ms.WriteByte(0);
                    ms.WriteByte(0);
                    //sessionid
                    byte[] dd = Util.int2ByteArray(mSessionId);
                    ms.Write(dd, 0, dd.Length);

                    //count
                    ms.WriteByte((byte)count);

                    for (int i = 0; i < count; i++)
                    {
                        RequestWrapper request = requestQueue.Dequeue();

                        ms.WriteByte(request.requestType);
                        byte[] body = serialize(request.request);

                        int length = body.Length;
                        byte[] ls = Util.short2ByteArray((short)body.Length);
                        ms.Write(ls, 0, 2);

                        ms.Write(body, 0, length);
                    }

                    byte[] data = ms.ToArray();
                    int l = data.Length - 2;
                    data[1] = (byte)l;
                    data[0] = (byte)(l >> 8);

                    return data;
                }
            }
            else
            {
                int count = requestQueue.Count;
                if (count > 0)
                {
                    var ms = new MemoryStream();

                    //length
                    ms.WriteByte(0);
                    ms.WriteByte(0);
                    //sessionid
                    byte[] dd = Util.int2ByteArray(mSessionId);
                    ms.Write(dd, 0, dd.Length);

                    //count
                    ms.WriteByte((byte)(count * MultiCount));

                    for (int i = 0; i < count; i++)
                    {
                        RequestWrapper request = requestQueue.Dequeue();

                        for (int j = 0; j < MultiCount; j++)
                        {
                            ms.WriteByte(request.requestType);
                            byte[] body = serialize(request.request);

                            int length = body.Length;
                            byte[] ls = Util.short2ByteArray((short)body.Length);
                            ms.Write(ls, 0, 2);

                            ms.Write(body, 0, length);
                        }
                    }

                    byte[] data = ms.ToArray();
                    int l = data.Length - 2;
                    data[1] = (byte)l;
                    data[0] = (byte)(l >> 8);

                    return data;
                }
            }
            return null;
        }
        #endregion

        #region serializer
        TBase deserialize(byte[] array, byte type)
        {
            var stream = new MemoryStream(array);
            TProtocol protocol = new TBinaryProtocol(new TStreamTransport(stream, stream));

            TBase tbase = com.think.data.protocol.ProtocolManager.instance.InstanceTBase(type, false);
            if (tbase != null)
            {
                tbase.Read(protocol);
            }
            else
            {
                if (IsDebug)
                {
                    Logger.Warning("QueueCache:::deserialize:::error:::type=" + type);
                }
            }
            return tbase;
        }

        byte[] serialize(TBase content)
        {
            var stream = new MemoryStream();

            TProtocol protocol = new TBinaryProtocol(new TStreamTransport(stream, stream));
            content.Write(protocol);

            byte[] data = stream.ToArray();

            return data;
        }
        #endregion
    }
}