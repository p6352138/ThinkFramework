using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.think.data.cache
{
    /// <summary>
    /// 差异化更新实例类型枚举
    /// </summary>
    public enum UpdateItemType : byte
    {
        /// <summary>
        /// 武将装备,背包物品更新
        /// </summary>
        Package = 1,
        /// <summary>
        /// 武将属性更新
        /// </summary>
        General = 2,
        /// <summary>
        /// 单个物品更新
        /// </summary>
        Goods = 3, 
        /// <summary>
        /// CD时间更新
        /// </summary>
        CDTime = 4, 
        /// <summary>
        /// 玩家属性更新
        /// </summary>
        Player = 5,
        /// <summary>
        /// 任务更新
        /// </summary>
        Task = 6, 
        /// <summary>
        /// 日常任务界面信息更新
        /// </summary>
        TaskInfo = 7, 
        /// <summary>
        /// 任务追踪更新
        /// </summary>
        TaskNotify = 8,
        /// <summary>
        /// 玩家好友更新
        /// </summary>
        Friend = 9,
        /// <summary>
        /// 武将属性更新
        /// </summary>
        GeneralAttribute = 10
    }

    /// <summary>
    /// 差异化更新类型
    /// </summary>
    public enum UpdateType : byte
    {
        /// <summary>
        /// 新增
        /// </summary>
        Add = 1,
        /// <summary>
        /// 删除
        /// </summary>
        Remove = 2,
        /// <summary>
        /// 更新
        /// </summary>
        Update = 3
    }

    /// <summary>
    /// 差异化更新实例接口
    /// </summary>
    public interface IUpdateItem : IComparable
    {
        UpdateItemType GetUpdateItemType();
    }
    
    /// <summary>
    /// 差异化更新接口
    /// </summary>
    public interface IUpdater
    {
        /// <summary>
        /// 更新单个实例
        /// </summary>
        /// <param name="item">更新实例</param>
        /// <param name="type">更新类型</param>
        void UpdateItem(IUpdateItem item,UpdateType type);
        /// <summary>
        /// 刷新所有实例列表
        /// </summary>
        /// <param name="items"></param>
        void UpdateItemList(List<IUpdateItem> items);
    }

    public abstract class IManager
    {
        /// <summary>
        /// 更新接口列表
        /// </summary>
        protected List<IUpdater> listeners = new List<IUpdater>();

        /// <summary>
        /// 实例列表
        /// </summary>
        protected List<IUpdateItem> items = new List<IUpdateItem>();

        /// <summary>
        /// 注册更新接口
        /// </summary>
        /// <param name="listner"></param>
        public virtual void regist(IUpdater listner)
        {
            if (!listeners.Contains(listner))
            {
                listeners.Add(listner);

                // 新注册接口需要刷新列表
                listner.UpdateItemList(items);
            }
        }

        /// <summary>
        /// 注销更新接口
        /// </summary>
        /// <param name="listener"></param>
        public virtual void unregist(IUpdater listener)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            }
        }

        /// <summary>
        /// 初始化实例列表
        /// </summary>
        /// <param name="items"></param>
        public void Init(List<IUpdateItem> items)
        {
            this.items = items;
            CallUpdateAll();
        }

        /// <summary>
        /// 添加实例
        /// </summary>
        /// <param name="item"></param>
        public void Add(IUpdateItem item)
        {
            if (Contains(item) == -1)
            {
                items.Add(item);
                CallUpdate(item, UpdateType.Add);
            }
        }

        /// <summary>
        /// 删除实例
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IUpdateItem item)
        {
            int index = Contains(item);
            if (index != -1)
            {
                items.RemoveAt(index);
                CallUpdate(item, UpdateType.Remove);
            }
        }

        /// <summary>
        /// 刷新实例,如果列表中未找到则新增
        /// </summary>
        /// <param name="item"></param>
        public void Update(IUpdateItem item)
        {
            int index = Contains(item); 
            if (index != -1)
            {
                items[index] = item;
                CallUpdate(item, UpdateType.Update);
            }
            else
            {
                items.Add(item);
                CallUpdate(item, UpdateType.Add);
            }
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public void Clear()
        {
            items.Clear();
            CallUpdateAll();
        }

        /// <summary>
        /// 判断是否包含
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Contains(IUpdateItem item)
        {
            for (int i = 0, count = items.Count; i < count; i++)
            {
                if (item.CompareTo(items[i]) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 更新单个实例
        /// </summary>
        /// <param name="item">单个实例</param>
        /// <param name="type">更新类型</param>
        protected void CallUpdate(IUpdateItem item, UpdateType type)
        {
            foreach (IUpdater listener in listeners)
            {
                 listener.UpdateItem(item, type);
            }
        }

        /// <summary>
        /// 刷新所有列表
        /// </summary>
        protected virtual void CallUpdateAll()
        { 
            foreach (IUpdater listener in listeners)
            {
                listener.UpdateItemList(items);
            }
        }
    }
}
