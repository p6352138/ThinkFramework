using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace com.think.manager
{
    public interface ISceneListener
    {
        void RemoveScene(int id);
        void AddLockScene(int id, byte style);
        void AddLockScene(com.think.data.cache.lockscene.LockSceneItem lsi);
        void activeGuideView(com.think.manager.guide.GuideItem item, GameObject eventReceiver);
        void activeGuideView(com.think.manager.guide.GuideItem item, GameObject eventReceiver, string functionName, bool isOut);
        void setLoadingState(bool state);
    }

    public class ISceneManager
    {
        private ISceneManager()
        {}
        private static ISceneManager ism;
        public static ISceneManager Instance
        {
            get
            {
                if (ism == null) ism = new ISceneManager();
                return ism;
            }
        }

        ISceneListener isl;
        public ISceneListener SceneManager
        {
            set
            {
                isl = value;
            }
            get
            {
                return isl;
            }
        }

        public IVersionControl versionController
        {
            set;
            get;
        }

        public UnityEngine.Transform cachedComponentParent { get; set; }

        /// <summary>
        /// 是否是过场界面
        /// </summary>
        bool isLoading = false;
        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                isLoading = value;
                SceneManager.setLoadingState(isLoading);
            }
        }

        // 过场界面结束后是否需要回调指引
        bool isCallbackFunctionManagerByLoaded = false;
        public bool IsCallBackFunctionManagerByLoaded { get { return isCallbackFunctionManagerByLoaded; } set { isCallbackFunctionManagerByLoaded = value; } }
    }
}
