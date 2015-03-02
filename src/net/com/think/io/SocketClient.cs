using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using com.think.io;
using com.think.messages;

namespace com.think.io
{
    public interface IParser
    {
        void onParse();
    }

    public interface INetStateNotify
    {
        /// <summary>
        /// 链接超时
        /// </summary>
        void NS_TimeOutConnect();
        /// <summary>
        /// 发送数据超时
        /// </summary>
        void NS_TimeOutSend();
        /// <summary>
        /// 接受数据超时
        /// </summary>
        void NS_TimeOutReceive();
        /// <summary>
        /// 链接失败
        /// </summary>
        void NS_ErrorConnect();
        /// <summary>
        /// 发送数据失败
        /// </summary>
        void NS_ErrorSend();
        /// <summary>
        /// 接受数据失败
        /// </summary>
        void NS_ErrorReceive();
        /// <summary>
        /// 开启外部定时检测
        /// </summary>
        void NS_StartTick();
        /// <summary>
        /// 关闭外部定时检测
        /// </summary>
        void NS_StopTick();
        /// <summary>
        /// 尝试失败后重置
        /// </summary>
        void NS_Reset();
    }

    sealed public class SocketClient
    {
        /// <summary>
        /// 是否打印调试语句
        /// </summary>
        public bool IsDebug { get; set; }

        /// <summary>
        /// 建立链接超时时间(s)
        /// </summary>
        public int timeout_connect = 1800;
        /// <summary>
        /// 发送数据超时时间(s)
        /// </summary>
        public float timeout_send = 30;
        /// <summary>
        /// 接受数据超时时间(s)
        /// </summary>
        public float timeout_receive = 30;
        /// <summary>
        /// 心跳最小发送周期(s)
        /// </summary>
        public float HeartBeatMinDuration = 10;

        /// <summary>
        /// 重试链接次数
        /// </summary>
        int retry_count_connect;
        /// <summary>
        /// 重试发送次数
        /// </summary>
        int retry_count_send;
        /// <summary>
        /// 重试接受次数
        /// </summary>
        int retry_count_receive;

        /// <summary>
        /// 重试链接最大次数
        /// </summary>
        public int retry_max_connect = 1;
        /// <summary>
        /// 重试发送最大次数
        /// </summary>
        public int retry_max_send = 1;
        /// <summary>
        /// 重试接受最大次数
        /// </summary>
        public int retry_max_receive = 1;

        /// <summary>
        /// 最大心跳次数
        /// </summary>
        public int retry_max_Heart = 2;

        /// <summary>
        /// 当前发送心跳包的次数
        /// </summary>
        public int current_heart_time = 0;

        /// <summary>
        /// 网络状态监听者
        /// </summary>
        public INetStateNotify NsNotify { get; set; }

        Socket clientSocket;
        string mUrl;
        int mPort;
        bool isIp = true;

        /// <summary>
        /// 接收缓冲区
        /// </summary>
        byte[] m_receiveBuffer = new byte[8 * 1024];

        /// <summary>
        /// 是否已经开始准备联网
        /// </summary>
        bool mIsStartConnect = false;

        bool mIsConnected = false;
        /// <summary>
        /// 是否已经链接成功
        /// </summary>
        public bool IsConnected
        {
            get
            {
                return mIsConnected;
            }
        }

        bool mIsSending = false;
        /// <summary>
        /// 是否正在发送数据
        /// </summary>
        public bool IsSending
        {
            get
            {
                return mIsSending;
            }
        }

        bool mIsReceiving = false;
        /// <summary>
        /// 是否正在接受数据
        /// </summary>
        public bool IsReceiving { get { return mIsReceiving; } }

        /// <summary>
        /// 最近一次开始链接时间
        /// </summary>
        DateTime lastConnectTime;
        /// <summary>
        /// 最近一次开始接受数据时间
        /// </summary>
        DateTime lastReceiveTime;
        /// <summary>
        /// 最近一次开始发送数据的时间
        /// </summary>
        DateTime lastSendTime;

        /// <summary>
        /// 是否已经发送过非心跳数据
        /// </summary>
        bool isSendData = false;

        /// <summary>
        /// 缓存最近一次发送的数据
        /// </summary>
        byte[] lastSendData;

        private SocketClient() { }
        public static readonly SocketClient instance = new SocketClient();

        public void checkTimeout()
        {
            DateTime current = DateTime.Now;
            if (IsDebug)
            {
                Logger.Log("checkTimeout::::::mIsStartConnect=" + mIsStartConnect + "/mIsConnected=" + mIsConnected + "/isSendData=" + isSendData + "/" + TFUtils.getCurrentTime());
            }
            // 检测链接超时
            if (mIsStartConnect && !mIsConnected && isTimeout(current, lastConnectTime, timeout_connect))
            {
                //retryConnect();
                //Disconnect();
                //Logger.Error("连接超时了");
                if (NsNotify != null) NsNotify.NS_TimeOutConnect();
                return;
            }
            //Logger.Error("current lastConnectTime timeout_connect" + current + " **** " + lastConnectTime + " **** " + timeout_connect);

            // 检测发送超时
            if (mIsSending && isTimeout(current, lastSendTime, timeout_send))
            {
                //retrySend();
                //Disconnect();
                //Logger.Error("发送超时了");
                if (NsNotify != null) NsNotify.NS_TimeOutSend();
                return;
            }

            //Logger.Error("current lastSendTime timeout_send" + current + " **** " + lastSendTime + " **** " + timeout_send);

            // 检测接受超时
            if (mIsReceiving && isTimeout(current, lastReceiveTime, timeout_receive))
            {
                //retryReceive();
                //Disconnect();
                //Logger.Error("检测接受超时了");
                if (NsNotify != null) NsNotify.NS_TimeOutReceive();
                return;
            }

            //Logger.Error("current lastReceiveTime timeout_receive" + current + " **** " + lastReceiveTime + " **** " + timeout_receive);

            if (isSendData && isTimeout(current, lastSendTime, HeartBeatMinDuration))
            {
                if (IsDebug)
                {
                    Logger.Log("SocketClient:::::add heart request" + TFUtils.getCurrentTime());
                }
                //Logger.Error("!!!!!!!!!!!!!!!!!!!!!!!!!!!发送心跳包了!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                QueueCache.instance.addHeartRequest();
                current_heart_time++;
            }

            //Logger.Error("current lastSendTime HeartBeatMinDuration" + current + " **** " + lastSendTime + " **** " + HeartBeatMinDuration);
            //Logger.Error("==================================================================================");
        }

        bool isTimeout(DateTime current, DateTime last, float duration)
        {
            TimeSpan span = current.Subtract(last);
            return span.TotalSeconds > duration;
        }

        public void setUrl(string url)
        {
            mUrl = url;
        }

        public void setPort(int port)
        {
            mPort = port;
        }

        public void Connect(string url_, int port_)
        {
            mUrl = url_;
            mPort = port_;
            isIp = _isIp(url_);
            //BeginConnect();
        }

        public void Connect(string url_, int port_, bool isIp_)
        {
            mUrl = url_;
            mPort = port_;
            isIp = isIp_;
            //BeginConnect();
        }

        bool _isIp(string url)
        {
            if (url.ToLower().StartsWith("http://"))
            {
                url = url.Substring("http://".Length);
            }
            if (url.ToLower().StartsWith("https://"))
            {
                url = url.Substring("https://".Length);
            }
            string[] strs = url.Split('.');
            for (int i = 0, length = strs.Length; i < length; i++)
            {
                if (!isNumberic(strs[i]))
                {
                    return false;
                }
            }
            return true;
        }

        protected bool isNumberic(string message)
        {
            System.Text.RegularExpressions.Regex rex =
            new System.Text.RegularExpressions.Regex(@"^\d+$");
            int result = -1;
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 开始链接服务器
        /// </summary>
        public void BeginConnect()
        {
            lock (this)
            {
                try
                {
                    Disconnect();

                    if (IsDebug)
                    {
                        Logger.Warning("BeginConnect>>>>>>>>>>>>>>>>>>>>>>>>>>" + mUrl + ":" + mPort + " / " + TFUtils.getCurrentTime());
                    }

                    mIsStartConnect = true;
                    lastConnectTime = DateTime.Now;

                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    clientSocket.NoDelay = true;
                    clientSocket.ReceiveBufferSize = 8 * 1024;
                    clientSocket.ReceiveTimeout = 5 * 1000;
                    clientSocket.SendBufferSize = 4 * 1024;
                    clientSocket.SendTimeout = 5 * 1000;

                    IPEndPoint point = null;
                    if (isIp)
                    {
                        IPAddress address = IPAddress.Parse(mUrl);
                        point = new IPEndPoint(address, mPort);
                    }
                    else
                    {
                        IPHostEntry ipHost = Dns.GetHostEntry(mUrl);
                        point = new IPEndPoint(ipHost.AddressList[0], mPort);
                    }

                    clientSocket.BeginConnect(point, new AsyncCallback(Connected), clientSocket);

                    if (NsNotify != null) NsNotify.NS_StartTick();
                }
                catch (Exception e)
                {
                    Logger.Warning(e.Message);
                    retryConnect();
                }
            }
        }

        void Connected(IAsyncResult iar)
        {
            if (IsDebug)
            {
                Logger.Info("Connected>>>>>>>>>>>>>>>>>>>>>>>>>>isSending:" + mIsSending + " / " + TFUtils.getCurrentTime());
            }

            Socket socket = (Socket)iar.AsyncState;
            socket.EndConnect(iar);

            retry_count_connect = 0;
            mIsConnected = true;

            if (!mIsSending)
            {
                BeginSendData();
            }

            if (!mIsReceiving)
            {
                BeginReceiveData();
            }
        }

        public void BeginSendData()
        {
            if (IsDebug)
            {
                Logger.Log("BeginSendData:::1:lastSendData=" + lastSendData + "/" + TFUtils.getCurrentTime());
            }
            if (lastSendData == null) lastSendData = QueueCache.instance.encode();
            if (lastSendData == null) return;

            isSendData = true;
            if (IsDebug)
            {
                Logger.Log("BeginSendData:::2:lastSendData=" + lastSendData.Length + "/" + TFUtils.getCurrentTime());
            }
            try
            {
                if (IsDebug)
                {
                    Logger.Log("BeginSendData>>>>>>>>>>>>>>>>>>>>>>>>>>" + lastSendData.Length + " / " + TFUtils.getCurrentTime());
                }

                mIsSending = true;
                lastSendTime = DateTime.Now;

                clientSocket.BeginSend(lastSendData, 0, lastSendData.Length, SocketFlags.None, new AsyncCallback(EndSendData), clientSocket);
            }
            catch (Exception e)
            {
                if (IsDebug)
                {
                    Logger.Warning(e.Message);
                }
                retrySend();
            }
        }

        void EndSendData(IAsyncResult iar)
        {
            Socket socket = (Socket)iar.AsyncState;
            socket.EndSend(iar);

            if (IsDebug)
            {
                Logger.Info("EndSendData>>>>>>>>>>>>>>>>>>>>>>>>>>" + " / isReceiving=" + mIsReceiving + " / " + TFUtils.getCurrentTime());
            }
            mIsSending = false;
            lastSendData = null;
            retry_count_send = 0;

            //if (!mIsReceiving) BeginReceiveData();
        }

        void BeginReceiveData()
        {
            if (mIsReceiving) return;

            try
            {
                if (IsDebug)
                {
                    Logger.Info("BeginReceiveData>>>>>>>>>>>>>>>>>>>>>>>>>>" + " / " + TFUtils.getCurrentTime());
                }
                mIsReceiving = true;
                lastReceiveTime = DateTime.Now;
                clientSocket.BeginReceive(m_receiveBuffer, 0, m_receiveBuffer.Length, SocketFlags.None, new AsyncCallback(EndReceiveData), clientSocket);
            }
            catch (Exception e)
            {
                if (IsDebug)
                {
                    Logger.Warning(e.Message);
                }
                retryReceive();
            }
        }

        void EndReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int length = remote.EndReceive(iar);

            if (IsDebug)
            {
                Logger.Info("EndReceiveData>>>>>>>>>>>>>>>>>>>>>>>>>>length=" + length + " / " + TFUtils.getCurrentTime());
            }

            mIsReceiving = false;
            retry_count_receive = 0;

            if (length > 0)
            {
                processReceiveData(m_receiveBuffer, 0, length);
                if (IsDebug)
                {
                    System.Text.StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < length; i++)
                    {
                        sb.Append(m_receiveBuffer[i]);
                        sb.Append(" ");
                    }
                    Logger.Info("Receive Data:" + sb.ToString());
                }
            }
            //Logger.Error("====================================================");
            //Logger.Error("接受到的长度是 ：" + length);
            //Logger.Error("====================================================");
            if (mIsConnected)
            {
                BeginReceiveData();
            }
        }

        bool isNewPackage = true;
        int packageDataOffset = 0;
        int packageDataLength = 0;
        byte[] packageData = null;
        void processReceiveData(byte[] data, int offset, int length)
        {
            if (isNewPackage)
            {
                // 包长
                packageDataLength = Util.byteArray2Short(new byte[] { data[offset], data[offset + 1] }) + 2;
                //Logger.Error("processReceiveData:::packageDataLength:" + packageDataLength + " / " + TFUtils.getCurrentTime());
                // 如果是一个完整的包
                if (offset + packageDataLength == length)
                {
                    //Logger.Error("processReceiveData:::complete package 1 / packageDataLength:" + packageDataLength + " / packageDataOffset:" + packageDataOffset + " / offset:" + offset + " / length:" + length + " / " + TFUtils.getCurrentTime());
                    packageData = new byte[packageDataLength];
                    Array.Copy(data, offset, packageData, 0, packageDataLength);
                    QueueCache.instance.decode(packageData);
                }
                // 如果粘包
                else if (offset + packageDataLength < length)
                {
                    //Logger.Error("processReceiveData:::keep read other package / packageDataLength:" + packageDataLength + " / packageDataOffset:" + packageDataOffset + " / offset:" + offset + " / length:" + length + " / offset:" + offset + " / length:" + length + " / " + TFUtils.getCurrentTime());
                    packageData = new byte[packageDataLength];
                    Array.Copy(data, offset, packageData, 0, packageDataLength);
                    QueueCache.instance.decode(packageData);

                    processReceiveData(data, offset + packageDataLength, length);
                }
                // 如果断包
                else
                {
                    //Logger.Error("processReceiveData:::split package / packageDataLength:" + packageDataLength + " / packageDataOffset:" + packageDataOffset + " / offset:" + offset + " / length:" + length + " / " + TFUtils.getCurrentTime());
                    packageData = new byte[packageDataLength];
                    Array.Copy(data, offset, packageData, 0, length - offset);
                    isNewPackage = false;
                    packageDataOffset = length - offset;
                }
            }
            else
            {
                // 断包后获取完整包
                if (packageDataOffset + length == packageDataLength)
                {
                    //Logger.Error("processReceiveData:::split package then read completed / packageDataLength:" + packageDataLength + " / packageDataOffset:" + packageDataOffset + " / offset:" + offset + " / length:" + length + " / " + TFUtils.getCurrentTime());
                    Array.Copy(data, offset, packageData, packageDataOffset, length);
                    QueueCache.instance.decode(packageData);
                    isNewPackage = true;
                    packageDataOffset = 0;
                }
                // 断包后没有获取完整的包
                else if (packageDataOffset + length < packageDataLength)
                {
                    //Logger.Error("processReceiveData:::split package till 2 / packageDataLength:" + packageDataLength + " / packageDataOffset:" + packageDataOffset + " / offset:" + offset + " / length:" + length + " / " + TFUtils.getCurrentTime());
                    Array.Copy(data, offset, packageData, packageDataOffset, length);
                    packageDataOffset += length;
                }
                // 断包后获取完整包并粘包
                else
                {
                    //Logger.Error("processReceiveData:::split package then keep read other package / packageDataLength:" + packageDataLength + " / packageDataOffset:" + packageDataOffset + " / offset:" + offset + " / length:" + length + " / " + TFUtils.getCurrentTime());
                    Array.Copy(data, offset, packageData, packageDataOffset, packageDataLength - packageDataOffset);
                    QueueCache.instance.decode(packageData);

                    isNewPackage = true;
                    int tmp = offset + packageDataLength - packageDataOffset;
                    Logger.Info("tmp:" + tmp + " / " + TFUtils.getCurrentTime());
                    packageDataOffset = 0;
                    processReceiveData(data, tmp, length);
                }
            }
        }

        public void Disconnect()
        {
            lock (this)
            {
                if (IsDebug)
                {
                    Logger.Log("Disconnect>>>>>>>>>>>>>>>>>>>>>>>>>>" + TFUtils.getCurrentTime());
                }

                if (NsNotify != null) NsNotify.NS_StopTick();

                mIsConnected = false;
                mIsStartConnect = false;
                mIsSending = false;
                isSendData = false;
                mIsReceiving = false;
                if (clientSocket == null)
                {
                    return;
                }
                try
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
                catch (Exception)
                {
                }
                finally
                {
                    clientSocket = null;
                }
            }
        }

        /// <summary>
        /// 检测发送数据超时或者发送数据失败时调用重试
        /// </summary>
        void retrySend()
        {
            retry_count_send++;
            if (IsDebug)
            {
                Logger.Log("retrySend::::retry_count_send=" + retry_count_send + "/ " + TFUtils.getCurrentTime());
            }
            if (retry_count_send >= retry_max_send)
            {
                retryConnect();
            }
            else
            {
                BeginSendData();
            }
        }

        /// <summary>
        /// 检测接受数据超时或者接受数据失败时调用重试
        /// </summary>
        void retryReceive()
        {
            retry_count_receive++;
            if (IsDebug)
            {
                Logger.Log("retryReceive::::retry_count_receive=" + retry_count_receive + "/ " + TFUtils.getCurrentTime());
            }
            if (retry_count_receive >= retry_max_receive)
            {
                retryConnect();
            }
            else
            {
                BeginReceiveData();
            }
        }

        /// <summary>
        /// 尝试重新链接
        /// </summary>
        void retryConnect()
        {
            retry_count_connect++;
            if (IsDebug)
            {
                Logger.Log("SocketClient:::retryConnect:::count=" + retry_count_connect + " / max=" + retry_max_connect + " / " + TFUtils.getCurrentTime());
            }
            if (retry_count_connect >= retry_max_connect)
            {
                reset();
            }
            else
            {
                BeginConnect();
            }
        }

        /// <summary>
        /// 尝试失败后调用重置
        /// </summary>
        void reset()
        {
            if (IsDebug)
            {
                Logger.Warning("SocketClient:::::backToLogin::::" + TFUtils.getCurrentTime());
            }

            Disconnect();

            lastSendData = null;
            retry_count_connect = 0;
            retry_count_send = 0;
            retry_count_receive = 0;

            QueueCache.instance.reset();

            if (NsNotify != null)
            {
                NsNotify.NS_Reset();
            }
        }

        /*
        /// <summary>
        /// 清除发送和接受队列
        /// </summary>
        void clearQueue()
        {
            lastSendData = null;
            retry_count_connect = 0;
            retry_count_send = 0;
            retry_count_receive = 0;

            com.think.manager.dialog.DialogManager.instance.clear();

            QueueCache.instance.ClearResponseList();
            QueueCache.instance.ClearRequestList();
        }*/
    }
}