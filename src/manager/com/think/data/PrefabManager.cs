using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System.IO;
//using System.Xml;
using LitJson;

namespace com.think.data.prefab
{
    class Tag
    {
        /// <summary>
        /// 界面预制管理文件
        /// </summary>
        public const string JSON_FILE_NAME_SCENE = "json/prefab-scene-mapping";
        
        public const string JSON_FILE_NAME_COMPONENT = "json/prefab-component-mapping";

        public const string PREFAB = "prefab",
                            ID = "id",
                            PATH = "path",
                            LEVEL = "level",
                            KEEP = "keep",
                            ORDER = "order";
    }

    public class ConfigItem
    {
        public string Path { get; set; }
        public byte Level { get; set; }
        public byte Keep { get; set; }
        int[] mOrderIds;
        public int[] OrderIds { get { return mOrderIds; } set { mOrderIds = value; } }

        /// <summary>
        /// 是否删除界面或组件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsDelete(int id)
        {
            if (Keep == 3) return false;
            if (Keep == 0 || Keep == 2) return true;
            if (mOrderIds == null) return false;
            foreach (int oid in mOrderIds)
            {
                if (oid == id) return true;
            }
            return false;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("config:").Append(" ");
            sb.Append("path:" + Path).Append(" ");
            sb.Append("level:" + Level).Append(" ");
            sb.Append("keep:" + Keep).Append(" ");
            sb.Append("order:");
            if (mOrderIds != null)
            {
                foreach (int id in mOrderIds) sb.Append(id + ", ");
            }

            return sb.ToString();
        }
    }
 
    public class PrefabManager
    {
        private PrefabManager() { }
        public static readonly PrefabManager instance = new PrefabManager();

        Dictionary<int, ConfigItem> configItems = new Dictionary<int, ConfigItem>();

        bool isLoad;

        public Dictionary<int, ConfigItem> Configs
        {
            get
            {
                if (!isLoad)
                {
                    loadJson();
                }
                return configItems;
            }
        }
        public ConfigItem GetSceneConfigItem(int id)
        {
            if (!isLoad)
            {
                loadJson();
            }
            ConfigItem item;
            if (configItems.TryGetValue(id, out item))
            {
                return item;
            }
            return null;
        }
   
        void loadJson()
        {
            TextAsset jta = Resources.Load(Tag.JSON_FILE_NAME_SCENE) as TextAsset;
            if (jta != null)
            {
                JsonData jData = JsonMapper.ToObject(jta.text);

                JsonData jp = jData[Tag.PREFAB];
                for (int i = 0, count = jp.Count; i < count; i++)
                {
                    int id = int.Parse(jp[i][Tag.ID].ToString());
                    string path = jp[i][Tag.PATH].ToString();
                    byte level = byte.Parse(jp[i][Tag.LEVEL].ToString());
                    ConfigItem ci = new ConfigItem();
                    ci.Path = path;
                    ci.Level = level;

                    if (jp[i].Count > 3)
                    {
                        byte keep = byte.Parse(jp[i][Tag.KEEP].ToString());
                        ci.Keep = keep;
                        if (jp[i].Count > 4)
                        {
                            string strOrder = jp[i][Tag.ORDER].ToString();

                            string[] ots = strOrder.Split(',');
                            int[] orders = new int[ots.Length];
                            for (int j = 0, length = ots.Length; j < length; j++) orders[j] = int.Parse(ots[j]);

                            ci.OrderIds = orders;
                        }
                    }
                    
                    configItems.Add(id, ci);
                }
                jData.Clear();
                jData = null;
                jta = null;
            }
            isLoad = true;
        } 
    }

    public class PrefabComponentManager
    {
        private PrefabComponentManager() { }
        public static readonly PrefabComponentManager instance = new PrefabComponentManager();

        public class ComponentConfigItem
        {
            public string Path { get; set; }
            public byte Keep { get; set; }
        }
        Dictionary<int, ComponentConfigItem> componentConfigItemMapping = new Dictionary<int, ComponentConfigItem>();

        bool isLoad;

        public Dictionary<int, ComponentConfigItem> Configs
        {
            get
            {
                if (!isLoad) loadJson();
                return componentConfigItemMapping;
            }
        }

        public Object GetPrefabComponent(int id)
        {
            ComponentConfigItem cci = GetPrefabComponentConfig(id);
            if (cci != null)
            {
                return Resources.Load(cci.Path);
            }
            return null;
        }

        public ComponentConfigItem GetPrefabComponentConfig(int id)
        {
            if (!isLoad)
            {
                loadJson();
            }
            ComponentConfigItem item;
            if (componentConfigItemMapping.TryGetValue(id, out item))
            {
                return item;
            }
            return null;
        }

        void loadJson()
        {
            TextAsset jta = Resources.Load(Tag.JSON_FILE_NAME_COMPONENT) as TextAsset;
            if (jta != null)
            {
                JsonData jData = JsonMapper.ToObject(jta.text);

                JsonData jp = jData[Tag.PREFAB];
                for (int i = 0, count = jp.Count; i < count; i++)
                {
                    int id = int.Parse(jp[i][Tag.ID].ToString());
                    string path = jp[i][Tag.PATH].ToString();
                    
                    ComponentConfigItem ci = new ComponentConfigItem();
                    ci.Path = path;
                    
                    if (jp[i].Count > 2)
                    {
                        byte keep = byte.Parse(jp[i][Tag.KEEP].ToString());
                        ci.Keep = keep;
                    }

                    componentConfigItemMapping.Add(id, ci);
                }
                jData.Clear();
                jData = null;
                jta = null;
            }
            isLoad = true;
        } 
    }
}
