using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;

namespace com.think.data.building
{
    /// <summary>
    /// 建筑物菜单功能
    /// </summary>
    public class FunctionItem
    {
        public string Name { get; set; }
        public byte Index { get; set; }
        public int SceneId { get; set; }
        public int Event { get; set; }
        public int Notify { get; set; }
        public Vector3 Scale { get; set; }
        public Vector3 Position { get; set; }
    }

    /// <summary>
    /// 建筑物
    /// </summary>
    public class BuildingItem
    {
        public byte Type { get; set; }
        public string Name { get; set; }
        public string Texture { get; set; }
        public string Dialog { get; set; }
        public List<FunctionItem> Functions { get; set; }

        public FunctionItem GetFunctionItem(int e)
        {
            foreach (FunctionItem item in Functions)
            {
                if (item.Event == e) return item;
            }
            return null;
        }
    }

    class Tag
    {
        public const string JSON_FILE_NAME = "json/building-mapping";

        public const string BUILDING = "building",
                            TYPE = "type",
                            NAME = "name",
                            TEXTURE = "texture",
                            DIALOG = "dialog",
                            MENU = "menu",
                            INDEX = "index",
                            SCENE = "scene",
                            EVENT = "event",
                            PX = "positionX",
                            PY = "positionY",
                            SX = "scaleX",
                            SY = "scaleY",
                            SPRITE = "sprite",
                            NOTIFY = "notify";
    }
    public class BuildingFunctionManager
    {
        private BuildingFunctionManager() { }
        public static readonly BuildingFunctionManager instance = new BuildingFunctionManager();

        Dictionary<byte, BuildingItem> buildings;
        bool isLoad;

        /// <summary>
        /// 根据建筑物类型获取建筑物实例
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public BuildingItem GetBuildingItem(byte type)
        {
            if (!isLoad)
            {
                loadJson();
            }

            if (buildings != null && buildings.ContainsKey(type))
            {
                return buildings[type];
            }
            return null;
        }

        void loadJson()
        {
            TextAsset ta = Resources.Load(Tag.JSON_FILE_NAME) as TextAsset;
            if (ta != null)
            {
                buildings = new Dictionary<byte, BuildingItem>();

                JsonData jData = JsonMapper.ToObject(ta.text);
                JsonData jis = jData[Tag.BUILDING];
                for (int i = 0, count = jis.Count; i < count; i++)
                {
                    BuildingItem building = parseBuildingItem(jis[i]);

                    buildings.Add(building.Type, building);
                }
                jData.Clear();
                jData = null;
                ta = null;
            }
            isLoad = true;
        }

        BuildingItem parseBuildingItem(JsonData element)
        {
            byte type = byte.Parse(element[Tag.TYPE].ToString());
            string bname = element[Tag.NAME].ToString();
            string texture = element[Tag.TEXTURE].ToString();

            List<FunctionItem> items = new List<FunctionItem>();
            JsonData child = element[Tag.MENU];
            if (child.IsArray)
            {
                for (int i = 0, count = child.Count; i < count; i++)
                {
                    string name = child[i][Tag.NAME].ToString();
                    byte index = byte.Parse(child[i][Tag.INDEX].ToString());
                    int sceneId = int.Parse(child[i][Tag.SCENE].ToString());
                    int e = int.Parse(child[i][Tag.EVENT].ToString());
                    int notify = int.Parse(child[i][Tag.NOTIFY].ToString());
                    float px = float.Parse(child[i][Tag.PX].ToString());
                    float py = float.Parse(child[i][Tag.PY].ToString());
                    float sx = float.Parse(child[i][Tag.SX].ToString());
                    float sy = float.Parse(child[i][Tag.SY].ToString());

                    FunctionItem item = new FunctionItem();
                    item.Name = name;
                    item.Index = index;
                    item.SceneId = sceneId;
                    item.Event = e;
                    item.Notify = notify;
                    item.Position = new Vector3(px, py, 0);
                    item.Scale = new Vector3(sx, sy, 0);

                    items.Add(item);
                }
            }
            else
            {
                string name = child[Tag.NAME].ToString();
                byte index = byte.Parse(child[Tag.INDEX].ToString());
                int sceneId = int.Parse(child[Tag.SCENE].ToString());
                int e = int.Parse(child[Tag.EVENT].ToString());
                int notify = int.Parse(child[Tag.NOTIFY].ToString());
                float px = float.Parse(child[Tag.PX].ToString());
                float py = float.Parse(child[Tag.PY].ToString());
                float sx = float.Parse(child[Tag.SX].ToString());
                float sy = float.Parse(child[Tag.SY].ToString());

                FunctionItem item = new FunctionItem();
                item.Name = name;
                item.Index = index;
                item.SceneId = sceneId;
                item.Event = e;
                item.Notify = notify;
                item.Position = new Vector3(px, py, 0);
                item.Scale = new Vector3(sx, sy, 0);

                items.Add(item);
            }

            BuildingItem building = new BuildingItem();
            building.Type = type;
            building.Name = bname;
            building.Texture = texture;
            building.Functions = items;

            return building;
        }
    }
}
