using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;

namespace com.think.data.menu
{
    class Tag
    {
        public const string TAG_NAME = "menu";
    }
    /*
    public class MainMenuData
    {
        public string version { get; set; }
        public List<MainMenuDataItem> items { get; set; }
    }

    public class MainMenuDataItem
    {
        public int index { get; set; }
        public string title { get; set; }
        public string background { get; set; }
        public string checkmark { get; set; }
        public List<MenuChildItem> children { get; set; }
    }

    public class MenuChildItem
    {
        public string name { get; set; }
        public string background { get; set; }
        public int eventValue { get; set; }
        public string icon { get; set; }
        public int notify { get; set; }
        public int scene { get; set; }
    }*/

    public class PageData
    {
        public string version { get; set; }
        public List<PageItem> pages { get; set; }
    }

    public class PageItem
    {
        public byte type { get; set; }
        public List<PageMenuItem> items { get; set; }
    }

    public class PageMenuItem
    {
        public int index { get; set; }
        public string title { get; set; }
        public string background { get; set; }
        public string checkmark { get; set; }
        public int notify { get; set; }
        public List<PageButtonItem> buttons { get; set; }
    }

    public class PageButtonItem
    {
        public string name { get; set; }
        public string background { get; set; }
        public int eventValue { get; set; }
        public string icon { get; set; }
        public int notify { get; set; }
        public int scene { get; set; }
    }

    public class MainMenuManager
    {
        private MainMenuManager() { }
        public static readonly MainMenuManager instance = new MainMenuManager();

        PageData data;
        public PageData Data
        {
            get
            {
                //if (data == null)
                {
                    loadJson();
                }
                return data;
            }
        }

        /// <summary>
        /// 加载本地存储Json数据
        /// </summary>
        void loadJson()
        {
            string text = com.think.manager.ISceneManager.Instance.versionController.loadText(Tag.TAG_NAME);
            if (!string.IsNullOrEmpty(text))
            {
                data = JsonMapper.ToObject<PageData>(text);
            }
        }
    }
}
