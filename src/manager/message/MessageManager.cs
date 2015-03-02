using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace com.think.manager.message
{
    /// <summary>
    /// 消息类型
    /// </summary>
    public enum MessageType : byte
    {
        /// <summary>
        /// 短消息
        /// </summary>
        ShortMessage = 1,
        /// <summary>
        /// 界面跳转提示消息
        /// </summary>
        AITip = 2
    }

    /// <summary>
    /// 消息实例
    /// </summary>
    public class MessageItem
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType msgType;
        /// <summary>
        /// 消息实体
        /// </summary>
        public Thrift.Protocol.TBase message;
    }

    public interface MessageListener
    {
        MessageType getMessageType();
        void OnMessage(MessageItem message);
    }

    public class MessageManager
    {
        private MessageManager() { }
        public static readonly MessageManager instance = new MessageManager();


        List<MessageItem> messages = new List<MessageItem>();
        List<MessageListener> listeners = new List<MessageListener>();

        public void acceptMessage(MessageType msgType, Thrift.Protocol.TBase response)
        {
            MessageItem item = new MessageItem();
            item.msgType = msgType;
            item.message = response;

            messages.Add(item);

#if UNITY_EDITOR
            //Logger.Log("short message=" + response + " / " + TFUtils.getCurrentTime());
#endif
            callback(item);
        }

        public void acceptMessage(MessageType msgType, List<Thrift.Protocol.TBase> responses)
        {
            foreach (Thrift.Protocol.TBase response in responses)
            {
                MessageItem item = new MessageItem();
                item.msgType = msgType;
                item.message = response;

#if UNITY_EDITOR
                //Logger.Log("acceptMessage message=" + response + " / " + TFUtils.getCurrentTime());
#endif
                messages.Add(item);
            }

            callback();
        }

        public void removeMessage(MessageItem message)
        {
            if (messages.Count > 0 && messages.Contains(message))
            {
                messages.Remove(message);
            }
        }

        public void regist(MessageListener listener)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
                callback();
            }
        }

        public void unregist(MessageListener listener)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            }
        }

        public void callback()
        {
            if (listeners.Count > 0 && messages.Count > 0)
            {
                //List<MessageItem> dels = new List<MessageItem>();
                foreach (MessageListener listener in listeners)
                {
                    foreach (MessageItem message in messages)
                    {
                        if (message.msgType == listener.getMessageType())
                        {
                            listener.OnMessage(message);
                            //dels.Add(message);
                        }
                    }
                }

                /*
                if (dels.Count > 0)
                {
                    foreach (MessageItem message in dels) messages.Remove(message);
                    dels.Clear();
                    dels = null;
                }*/
            }
        }

        void callback(MessageItem message)
        {
            if (listeners.Count > 0)
            {
                foreach (MessageListener listener in listeners)
                {
                    if (message.msgType == listener.getMessageType())
                    {
                        listener.OnMessage(message);
                    }
                }
            }
        }
    }
}
