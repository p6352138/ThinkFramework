using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System.IO;
//using System.Xml;
using System.Reflection;
using Thrift.Protocol;
using LitJson;

namespace com.think.data.protocol
{
    class XmlTag
    {
        //public const string RESPONSE_XML_FILE_NAME = "xml/response-mapping";
        public const string RESPONSE_JSON_FILE_NAME = "json/response-mapping";
        public const string RESPONSE_ITEM = "response";
        public const string RESPONSE_CLASS = "responseClass";

        //public const string REQUEST_XML_FILE_NAME = "xml/request-handler";
        public const string REQUEST_JSON_FILE_NAME = "json/request-handler";
        public const string REQUEST_ITEM = "request";
        public const string REQUEST_CLASS = "requestClass";

        public const string ID = "id";
    }

    public class ProtocolManager
    {
        private ProtocolManager() { }
        public static readonly ProtocolManager instance = new ProtocolManager();

        Dictionary<byte, string> responseMapping = new Dictionary<byte, string>();
        Dictionary<byte, string> requestMapping = new Dictionary<byte, string>();

        readonly string protocolAssemblyName = "Protocol";

        /// <summary>
        /// 初始化,读取消息XML文件和获取消息DLL文件路径
        /// </summary>
        public void Init()
        {
            //loadRequestXML();
            //loadResponseXML();
            loadRequest();
            loadResponse();
        }

        void loadResponse()
        {
            TextAsset ta = Resources.Load(XmlTag.RESPONSE_JSON_FILE_NAME) as TextAsset;
            if (ta != null)
            {
                JsonData jData = JsonMapper.ToObject(ta.text);
                JsonData jis = jData[XmlTag.RESPONSE_ITEM];
                for (int i = 0, count = jis.Count; i < count; i ++)
                {
                    byte type = byte.Parse(jis[i][XmlTag.ID].ToString());
                    string value = jis[i][XmlTag.RESPONSE_CLASS].ToString();
                    responseMapping.Add(type, value);
                }

                jData.Clear();
                jData = null;
                ta = null;
            }
        }

        void loadRequest()
        {
            TextAsset ta = Resources.Load(XmlTag.REQUEST_JSON_FILE_NAME) as TextAsset;
            if (ta != null)
            {
                JsonData jData = JsonMapper.ToObject(ta.text);
                JsonData jis = jData[XmlTag.REQUEST_ITEM];
                for (int i = 0, count = jis.Count; i < count; i++)
                {
                    byte type = byte.Parse(jis[i][XmlTag.ID].ToString());
                    string value = jis[i][XmlTag.REQUEST_CLASS].ToString();
                    requestMapping.Add(type, value);
                }
                jData.Clear();
                jData = null;
                ta = null;
            }
        }

        /*
        void loadResponseXML()
        {
            TextAsset ta = Resources.Load(XmlTag.RESPONSE_XML_FILE_NAME) as TextAsset;
            if (ta != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ta.text);

                XmlNodeList xnl = doc.DocumentElement.ChildNodes;
                foreach (XmlElement element in xnl)
                {
                    if (element.Name.ToLower() == XmlTag.RESPONSE_ITEM)
                    {
                        byte type = byte.Parse(element.Attributes[XmlTag.ID].Value);
                        string value = element.Attributes[XmlTag.RESPONSE_CLASS].Value;
                        responseMapping.Add(type, value);
                    }
                }
            }
        }
        
        void loadRequestXML()
        {
            TextAsset ta = Resources.Load(XmlTag.REQUEST_XML_FILE_NAME) as TextAsset;
            if (ta != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ta.text);

                XmlNodeList xnl = doc.DocumentElement.ChildNodes;
                foreach (XmlElement element in xnl)
                {
                    if (element.Name.ToLower() == XmlTag.REQUEST_ITEM)
                    {
                        byte type = byte.Parse(element.Attributes[XmlTag.ID].Value);
                        string value = element.Attributes[XmlTag.REQUEST_CLASS].Value;
                        requestMapping.Add(type, value);
                    }
                }
            }
        }
        */

        /// <summary>
        /// 根据协议类型获取协议对应的消息类的名称
        /// </summary>
        /// <param name="id">协议编号</param>
        /// <param name="isRequest">是否是请求消息</param>
        /// <returns></returns>
        public string GetClassName(byte id, bool isRequest)
        {
            if (isRequest)
            {
                if (requestMapping.ContainsKey(id))
                {
                    return requestMapping[id];
                }
            }
            else
            {
                if (responseMapping.ContainsKey(id))
                {
                    return responseMapping[id];
                }
            }
            return null;
        }

        /// <summary>
        /// 根据消息类型实例化一个TBase
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isRequest"></param>
        /// <returns></returns>
        public TBase InstanceTBase(byte type, bool isRequest)
        {
            string name = GetClassName(type, isRequest);
            //Logger.Log("protocal name=" + name);
            if (!string.IsNullOrEmpty(name))
            {
                
                System.Type _type = System.Type.GetType(name);
                //Logger.Log("protocal _type=" + _type);
                TBase tbase = (TBase)System.Activator.CreateInstance(_type);
                return tbase;
                 
                /*
                Assembly ass = Assembly.Load(protocolAssemblyName);
                //Logger.Log("ass=" + ass);
                if (ass != null)
                {
                    object o = ass.CreateInstance(name);
                    //Logger.Log("o=" + o);
                    if (o != null)
                    {
                        return (TBase)o;
                    }
                }
                */
            }
            return null;
        }
    }
}
