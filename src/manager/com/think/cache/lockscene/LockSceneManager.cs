using UnityEngine;
using System.Collections.Generic;
using LitJson;

namespace com.think.data.cache.lockscene
{
    class Tag
    {
        public const string JSON_FILE_NAME = "json/lock-mapping";

        public const string XML_ITEM = "lock";
        public const string REQUEST = "request";
        public const string REQUEST_TYPE = "reqType";
        public const string STYLE = "style";
        public const string TEXT = "text";
        public const string RESPONSE = "response";
        public const string RESPONSE_TYPE = "respType";
        public const string MIN = "min";
        public const string SCENE = "scene";
    }

    /// <summary>
    /// 锁屏配置实例
    /// </summary>
    public class LockSceneItem
    {
        /// <summary>
        /// 上行请求协议编号
        /// </summary>
        public byte Request { get; set; }
        /// <summary>
        /// 上行请求协议中(type)类型编号，如果没有该属性值则为99 
        /// </summary>
        public byte RequestType { get; set; }
        /// <summary>
        /// 锁屏加载的动画类型 0-全屏 1-非全屏 2-锁按键 9-战斗过场
        /// </summary>
        public byte Style { get; set; }
        /// <summary>
        /// 对应下行的协议编号，可能是多个，并以逗号分隔
        /// </summary>
        public byte[] Responses { get; set; }
        /// <summary>
        /// 对应下行的协议编号中对应的类型编号，如果没有该属性值则为99
        /// </summary>
        public byte[] ResponseTypes { get; set; }
        /// <summary>
        /// 锁屏显示的文字内容
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 最短停留时间(s)，当style为2时表示锁按键的时间
        /// </summary>
        public float MinTime { get; set; }
        /// <summary>
        /// 需要切换界面时的界面编号，当style为2时该值表示指定锁住按键的OperationId
        /// </summary>
        public int SceneId { get; set; }
    }

    /// <summary>
    /// 锁屏配置管理器
    /// </summary>
    public class LockSceneManager
    {
        private LockSceneManager() { }
        public static readonly LockSceneManager instance = new LockSceneManager();

        List<LockSceneItem> items = null;
        const char REGEX = ',';

        LockSceneItem current;

        public void SetItems(List<LockSceneItem> its)
        {
            items = its;
        }

        /// <summary>
        /// 判断上行是否需要锁屏
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="requestType"></param>
        /// <returns></returns>
        public LockSceneItem GetLockSceneItem(byte requestId, byte requestType)
        {
            if (items == null)
            {
                loadJson();
            }

            foreach (LockSceneItem lsi in items)
            {
                if (lsi.Request == requestId && lsi.RequestType == requestType)
                {
                    current = lsi;
                    return current;
                }
            }
            return null;
        }

        /// <summary>
        /// 判断下行是否解锁
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="responseType"></param>
        /// <returns></returns>
        public bool isUnlock(byte responseId, byte responseType)
        {
            if (items == null)
            {
                loadJson();
            }

            if (current != null)
            {
                for (int i = 0, length = current.Responses.Length; i < length; i ++)
                {
                    if (current.Responses[i] == responseId && current.ResponseTypes[i] == responseType)
                    {
                        return true;
                    }
                }
                return false;
            }
            return true;
        }

        void loadJson()
        {
            TextAsset ta = Resources.Load(Tag.JSON_FILE_NAME) as TextAsset;
            if (ta != null)
            {
                items = new List<LockSceneItem>();

                JsonData jData = JsonMapper.ToObject(ta.text);
                JsonData jis = jData[Tag.XML_ITEM];
                for (int i = 0, count = jis.Count; i < count; i++)
                {
                    byte request = byte.Parse(jis[i][Tag.REQUEST].ToString());
                    byte requestType = byte.Parse(jis[i][Tag.REQUEST_TYPE].ToString());
                    byte style = byte.Parse(jis[i][Tag.STYLE].ToString());
                    string text = jis[i][Tag.TEXT].ToString();
                    string responseText = jis[i][Tag.RESPONSE].ToString();
                    string responseTypeText = jis[i][Tag.RESPONSE_TYPE].ToString();
                    byte[] response = null;
                    byte[] responseType = null;
                    if (responseText.IndexOf(REGEX) != -1)
                    {
                        string[] strs = responseText.Split(new char[] { REGEX });
                        response = new byte[strs.Length];
                        for (int j = 0, length = strs.Length; j < length; j++)
                        {
                            response[j] = byte.Parse(strs[j]);
                        }
                    }
                    else
                    {
                        response = new byte[] { byte.Parse(responseText) };
                    }
                    if (responseTypeText.IndexOf(REGEX) != -1)
                    {
                        string[] strs = responseTypeText.Split(new char[] { REGEX });
                        responseType = new byte[strs.Length];
                        for (int j = 0, length = strs.Length; j < length; j++)
                        {
                            responseType[j] = byte.Parse(strs[j]);
                        }
                    }
                    else
                    {
                        responseType = new byte[] { byte.Parse(responseTypeText) };
                    }
                    float minTime = float.Parse(jis[i][Tag.MIN].ToString());
                    int sceneId = int.Parse(jis[i][Tag.SCENE].ToString());

                    LockSceneItem item = new LockSceneItem();
                    item.Request = request;
                    item.RequestType = requestType;
                    item.Style = style;
                    item.Text = text;
                    item.Responses = response;
                    item.ResponseTypes = responseType;
                    item.MinTime = minTime;
                    item.SceneId = sceneId;

                    items.Add(item);
                }
                jData.Clear();
                jData = null;
                ta = null;
            }
        }
    }
}