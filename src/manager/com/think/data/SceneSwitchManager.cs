using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System.IO;
//using System.Xml;
using LitJson;

namespace com.think.data.switchScene
{
    /// <summary>
    /// 导航栏项目
    /// </summary>
    public class NaviPaneItem
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 对应界面编号
        /// </summary>
        public int Switch { get; set; }

        /// <summary>
        /// 功能ID
        /// </summary>
        public int FunctionId { get; set; }

        /// <summary>
        /// 特殊事件响应编号
        /// </summary>
        public int Event { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool Selection { get; set; }
    }

    /// <summary>
    /// 界面实例
    /// </summary>
    public class SceneItem
    {
        // 界面编号
        public int Id { get; set; }
        // 界面名称
        public string Title { get; set; }
        // 是否包含帮助
        public bool IsHelp { get; set; }
        // 帮助内容
        public string Help { get; set; }
        // 导航栏项目
        public List<NaviPaneItem> NaviPaneItems { get; set; }

        public string[][] GetNaviPaneInfo()
        {
            if (NaviPaneItems != null)
            {
                string[][] npis = new string[NaviPaneItems.Count][];
                int i = 0;
                foreach (NaviPaneItem npi in NaviPaneItems)
                {
                    npis[i] = new string[2];
                    npis[i][0] = npi.Name;
                    i++;
                }
                return npis;
            }
            return null;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("id:" + Id);
            sb.Append("\n");
            sb.Append("title:" + Title);
            sb.Append("\n");
            sb.Append("isHelp:" + IsHelp);
            sb.Append("\n");
            return sb.ToString();
        }
    }

    class XmlTag
    {
        //public const string XML_FILE_NAME = "xml/scene-mapping";
        public const string JSON_FILE_NAME = "Scene";

        public const string SCENE = "scene",
                            ID = "id",
                            TITLE = "title",
                            HELP = "help",
                            CONTENT = "content",
                            NAVIPANE = "navipane",
                            NAVIPANE_ITEM = "npi",
                            NAME = "name",
                            FUNCTION = "function",
                            EVENT = "event",
                            SELECTION = "selection",
                            SWITCH = "switch";
                            
    }

    public class SceneSwitchManager
    {
        private SceneSwitchManager() { }
        public static readonly SceneSwitchManager instance = new SceneSwitchManager();

        Dictionary<int, SceneItem> mapping = new Dictionary<int,SceneItem>();
        bool isLoad;

        public SceneItem GetSceneItem(int id)
        {
            if (!isLoad)
            {
                //loadXml();
                loadJson();
            }

            if (mapping.ContainsKey(id))
            {
                return mapping[id];
            }
            return null;
        }

        void loadJson()
        {
            string text = com.think.manager.ISceneManager.Instance.versionController.loadText(XmlTag.JSON_FILE_NAME);
            if (!string.IsNullOrEmpty(text))
            {
                JsonData jData = JsonMapper.ToObject(text);
                JsonData jis = jData[XmlTag.SCENE];
                for (int i = 0, count = jis.Count; i < count; i++)
                {
                    SceneItem si = parseSceneItem(jis[i]);
                    mapping.Add(si.Id, si);
                }
                isLoad = true;
            }
        }

        SceneItem parseSceneItem(JsonData element)
        {
            SceneItem item = new SceneItem();
            item.Id = int.Parse(element[XmlTag.ID].ToString());
            item.Title = element[XmlTag.TITLE].ToString();

            JsonData jHelp = element[XmlTag.HELP];
            if (jHelp.Count > 0)
            {
                string content = jHelp[XmlTag.CONTENT].ToString();
                item.IsHelp = true;
                item.Help = content;
            }

            if (element.Count >= 4)
            {
                JsonData jNav = element[XmlTag.NAVIPANE];
                JsonData jis = jNav[XmlTag.NAVIPANE_ITEM];

                List<NaviPaneItem> navis = new List<NaviPaneItem>();

                for (int i = 0, count = jis.Count; i < count; i++)
                {
                    NaviPaneItem npi = new NaviPaneItem();
                    npi.Name = jis[i][XmlTag.NAME].ToString();
                    npi.Switch = int.Parse(jis[i][XmlTag.SWITCH].ToString());
                    npi.FunctionId = int.Parse(jis[i][XmlTag.FUNCTION].ToString());
                    npi.Event = int.Parse(jis[i][XmlTag.EVENT].ToString());
                    npi.Selection = bool.Parse(jis[i][XmlTag.SELECTION].ToString());

                    navis.Add(npi);
                }
                item.NaviPaneItems = navis;
            }
            return item;
        }

        /*
        void loadXml()
        {
            TextAsset ta = Resources.Load(XmlTag.XML_FILE_NAME) as TextAsset;
            if (ta != null)
            {
                XmlDocument doc = new XmlDocument(); 
                doc.LoadXml(ta.text);

                XmlNodeList xnl = doc.DocumentElement.ChildNodes;
                foreach (XmlElement element in xnl)
                {
                    if (element.Name.ToLower() == XmlTag.SCENE)
                    {
                        SceneItem si = parseSceneItem(element);
                        mapping.Add(si.Id, si);
                    }
                }
                isLoad = true;
            }
        }

        SceneItem parseSceneItem(XmlElement element)
        {
            SceneItem item = new SceneItem();
            item.Id = int.Parse(element.Attributes[XmlTag.ID].Value);
            item.Title = element.Attributes[XmlTag.TITLE].Value;

            XmlNodeList helpNodes = element.GetElementsByTagName(XmlTag.HELP);
            if (helpNodes != null)
            {
                XmlNode helpNode = helpNodes.Item(0);
                //Logger.Log(item.Title + " / " + helpNode + " / " + helpNode.Attributes.Count);
                if (helpNode.Attributes.Count > 0)
                {
                    string content = helpNode.Attributes[XmlTag.CONTENT].Value;
                    item.IsHelp = true;
                    item.Help = content;
                }
            }

            XmlNodeList nvie = element.GetElementsByTagName(XmlTag.NAVIPANE_ITEM);
            if (nvie != null)
            {
                List<NaviPaneItem> navis = new List<NaviPaneItem>();
                foreach (XmlElement xe in nvie)
                {
                    if (xe.Name == XmlTag.NAVIPANE_ITEM)
                    {
                        NaviPaneItem npi = new NaviPaneItem();
                        npi.Name = xe.Attributes[XmlTag.NAME].Value;
                        npi.Switch = int.Parse(xe.Attributes[XmlTag.SWITCH].Value);
                        npi.FunctionId = int.Parse(xe.Attributes[XmlTag.FUNCTION].Value);
                        npi.Event = int.Parse(xe.Attributes[XmlTag.EVENT].Value);
                        npi.Selection = bool.Parse(xe.Attributes[XmlTag.SELECTION].Value);

                        navis.Add(npi);
                    }
                }
                item.NaviPaneItems = navis;
            }
            return item;
        }
        */
    }
}
