using System;
using System.Collections.Generic;
using com.think.data.cache;
using com.think.messages;

namespace com.think.data.cache.package
{
    public interface IPackageUpdater : IUpdater
    {

    }

    public class GoodsItem : IUpdateItem
    {
        public BagResponse Response { get; set; }

        public int CompareTo(object obj)
        {
            GoodsItem other = obj as GoodsItem;
            if (this.Response.InstanceID == other.Response.InstanceID)
            {
                return 0;
            }
            return -1;
        }

        public UpdateItemType GetUpdateItemType()
        {
            return UpdateItemType.Goods;
        }
    }

    public class PackageItem:IUpdateItem
    {
        public int OwnerUserID { get; set; }

        List<GoodsItem> bags = new List<GoodsItem>();
        public List<GoodsItem> Bags
        {
            get { return bags; }
            set
            {
                bags = value;
            }
        }

        public int CompareTo(object obj)
        {
            PackageItem other = obj as PackageItem;
            if (this.OwnerUserID == other.OwnerUserID)
            {
                return 0;
            }
            return -1;
        }

        public UpdateItemType GetUpdateItemType()
        {
            return UpdateItemType.Package;
        }
    }

    public class PackageManager :IManager
    {
        private PackageManager()
	    {
            //添加仓库
            PackageItem pi = new PackageItem();
            pi.OwnerUserID = 0;
            items.Add(pi);
	    }
        public static readonly PackageManager instance = new PackageManager();

        // 背包解锁格子数
        public static int PlayerBagUnLoackMaxNum = 8;
        // 最大背包格子
        public static int maxPackBoxNum = 64;
        //背包
        public PackageItem piPack;
        /// <summary>
        /// 初始化仓库
        /// </summary>
        /// <param name="bagList"></param>
        public void InitBagList(PlayerBagResponse bagList)
        {
            PlayerBagUnLoackMaxNum = bagList.Size; 
            if (piPack == null)
            {
                piPack = new PackageItem();
                piPack.OwnerUserID = 0;
                items.Add(piPack);
            }

            List<GoodsItem> iis = new List<GoodsItem>();
            foreach (BagResponse gr in bagList.PlayerBag)
            {
                GoodsItem gi = new GoodsItem();
                gi.Response = gr;
                iis.Add(gi);
            }

            piPack.Bags = iis;

            CallUpdate(piPack, UpdateType.Update);
        }

        /// <summary>
        /// 判断武将身上的装备是否可升级
        /// </summary>
        /// <param name="item">装备</param>
        /// <param name="callback">是否回调更新</param>
        void checkGoodsItemInBodyUpgrade(GoodsItem item, bool callback)
        {
            if (piPack != null && item.Response.ItemDetail != null && item.Response.ItemDetail.Material != null && item.Response.ItemDetail.Material.MaterialList.Count > 0)
            {
                bool mIsUpgrade = false;
                int mid = item.Response.ItemDetail.Material.MaterialList[0].MaterialId;
                foreach (GoodsItem goods in piPack.Bags)
                {
                    if (goods.Response.ItemId == mid)
                    {
                        mIsUpgrade = true;
                        break;
                    }
                }

                if (item.Response.ItemDetail.IsUpgrade != mIsUpgrade)
                {
                    item.Response.ItemDetail.IsUpgrade = mIsUpgrade;
                    if (callback) CallUpdate(item, UpdateType.Update);
                }
            }
        }

        /// <summary>
        /// 根据新增的背包内物品判断武将身上的装备是否可升级
        /// </summary>
        /// <param name="response">背包内物品</param>
        /// <param name="pi">武将身上的装备集合</param>
        /// <param name="callback">是否回调更新</param>
        void checkGoodsItemInBodyUpgrade(BagResponse response, PackageItem pi, bool callback)
        {
            if (response.ItemDetail != null && pi != null && pi.Bags.Count > 0)
            {
                bool mIsUpgrade = response.Nums > 0;
                foreach (GoodsItem goods in pi.Bags)
                {
                    if (goods.Response.ItemDetail != null && goods.Response.ItemDetail.Material != null &&
                        goods.Response.ItemDetail.Material.MaterialList != null && goods.Response.ItemDetail.Material.MaterialList.Count > 0 &&
                        goods.Response.ItemDetail.Material.MaterialList[0].MaterialId == response.ItemDetail.ItemId && goods.Response.ItemDetail.IsUpgrade != mIsUpgrade)
                    {
                        //Logger.Log("checkGoodsItemInBodyUpgrade:::" + pi.OwnerUserID + " / " + Utils.getCurrentTime());
                        goods.Response.ItemDetail.IsUpgrade = mIsUpgrade;
                        if (callback) CallUpdate(goods, UpdateType.Update);
                    }
                }
            }
        }

        /// <summary>
        /// 返回背包中同种类型的数量
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
       public int GetItemNumByItemId(int itemID)
       {
           int index = 0; 
           if (piPack != null && piPack.Bags != null)
           {
               foreach (GoodsItem good in piPack.Bags)
               {
                   if(good.Response.ItemId == itemID)
                   {
                       index++;
                   }
               }
           }
           return index;
       }

        /// <summary>
        /// 根据物品id在背包中查找具有同样物品id的物品
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
       public BagResponse GetBagResponse(int itemId)
       {
           if (piPack != null)
           {
               foreach (GoodsItem item in piPack.Bags)
               {
                   if (item.Response.ItemId == itemId)
                   {
                       return item.Response;
                   }
               }
           }
           return null;
       }

        /// <summary>
        /// 返回背包中此id物品的总数量
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
       public int GetItemDetailNumItemId(int itemID)
       {
           int num = 0;
           if (piPack != null && piPack.Bags != null)
           {
               foreach (GoodsItem good in piPack.Bags)
               {
                   if (good.Response.ItemId == itemID)
                   {
                       num += good.Response.Nums;
                   }
               }
           }
           return num;
       }

        /// <summary>
        /// 初始化武将身上装备
        /// </summary>
        /// <param name="general"></param>
        public void UpdateGeneralEquip(GeneralResponse general)
        {
            if (general.EquipmentOnBody != null)
            {
                PackageItem pi = GetPackageItemByOwnerUserId(general.General_id);
                if (pi == null)
                {
                    pi = new PackageItem();
                    pi.OwnerUserID = general.General_id;
                    items.Add(pi);
                }
                 
                List<GoodsItem> iis = new List<GoodsItem>();
                foreach (BagResponse gr in general.EquipmentOnBody)
                {
                    //Logger.Log("UpdateGeneralEquip:::" + gr + " / " + Utils.getCurrentTime());
                    //if (gr.ItemDetail != null && gr.ItemDetail.Material != null && gr.ItemDetail.Material.MaterialList != null)
                    //   Logger.Log("---UpdateGeneralEquip:::" + general.Name + " / " + gr + " / " + gr.ItemDetail + " / " + gr.ItemDetail.Material + " / " + gr.ItemDetail.Material.MaterialList + " / " + gr.ItemDetail.Material.MaterialList[0].MaterialId + " / "+ Utils.getCurrentTime());
                    GoodsItem gi = new GoodsItem();
                    gi.Response = gr;
                    iis.Add(gi);
                    checkGoodsItemInBodyUpgrade(gi, false);
                } 

                pi.Bags = iis; 
                
                CallUpdate(pi, UpdateType.Update);
            }
        }

        /// <summary>
        /// 刷新单个物品的合成材料部分信息
        /// </summary>
        /// <param name="resp"></param>
        public void UpdateItemSynthesizeMaterial(ItemSynthesizeMaterialResponse resp)
        {
            //Logger.Log("UpdateItemSynthesizeMaterial::::" + resp + " / " + Utils.getCurrentTime());
            foreach (PackageItem pi in items)
            {
                if (pi.Bags != null && pi.Bags.Count > 0)
                {
                    foreach (GoodsItem good in pi.Bags)
                    {
                        if (good.Response.InstanceID == resp.InstanceID)
                        {
                            good.Response.ItemDetail.Material = resp;
                            if (good.Response.OwnerUserID != 0)
                            {
                                checkGoodsItemInBodyUpgrade(good, false);
                            }
                            CallUpdate(good, UpdateType.Update);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 更新单个物品
        /// </summary>
        /// <param name="responseText"></param>
        public void UpdateBagResponse(BagResponse response)
        {
           // Logger.Log("UpdateBagResponse:::" + response + " / " + TFUtils.getCurrentTime());
            //if (response.ItemDetail != null && response.ItemDetail.Material != null && response.ItemDetail.Material.MaterialList != null)
            //    Logger.Log("----UpdateBagResponse:::" + response.OwnerUserID + " / " + response + " / " + response.ItemDetail + " / " + response.ItemDetail.Material + " / " + response.ItemDetail.Material.MaterialList + " / " + Utils.getCurrentTime());
            
            PackageItem pi = GetPackageItemByOwnerUserId(response.GeneralID); 
            if (pi != null)
            {
                if (pi.Bags != null)
                { 
                    foreach (GoodsItem goods in pi.Bags)
                    {
                        if (response.Index == goods.Response.Index)
                        { 
                            if (response.Nums == 0)
                            {
                                CallUpdate(goods, UpdateType.Remove);
                                pi.Bags.Remove(goods);
                            }
                            else
                            {
                                goods.Response = response;

                                if (response.GeneralID == 0)
                                {
                                    foreach (PackageItem pii in items)
                                    {
                                        if (pii.OwnerUserID != 0)
                                        {
                                            checkGoodsItemInBodyUpgrade(response, pii, true);
                                        }
                                    }
                                }
                                else
                                {
                                    checkGoodsItemInBodyUpgrade(goods, false);
                                }

                                CallUpdate(goods, UpdateType.Update);
                            }
                            return;
                        }
                    }
                }

                if (pi.Bags == null)
                {
                    pi.Bags = new List<GoodsItem>();
                }
                GoodsItem item = new GoodsItem();
                item.Response = response;
                pi.Bags.Add(item);

                if (response.GeneralID == 0)
                {
                    foreach (PackageItem pii in items)
                    {
                        if (pii.OwnerUserID != 0)
                        {
                            checkGoodsItemInBodyUpgrade(response, pii, true);
                        }
                    }
                }
                else
                {
                    checkGoodsItemInBodyUpgrade(item, false);
                }

                CallUpdate(item, UpdateType.Add);
            }
        }

        /// <summary>
        /// 根据所有者编号查找背包或仓库
        /// </summary>
        /// <param name="ownerUserId"></param>
        /// <returns></returns>
        public PackageItem GetPackageItemByOwnerUserId(int ownerUserId)
        {
            if (ownerUserId == 0) return piPack;
            foreach (IUpdateItem item in items)
            {
                if (item.GetUpdateItemType() == UpdateItemType.Package)
                {
                    PackageItem pi = item as PackageItem;
                    if (pi.OwnerUserID == ownerUserId)
                    { 
                        return pi;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 刷新物品信息
        /// </summary>
        /// <param name="item"></param>
        public void UpdateItem(BagResponse item)
        {
            //Logger.Log("UpdateItem:::" + item + " / " + Utils.getCurrentTime());
            //if (item.ItemDetail != null && item.ItemDetail.Material != null && item.ItemDetail.Material.MaterialList != null)
            //    Logger.Log("----UpdateItem:::" + item.OwnerUserID + " / " + item + " / " + item.ItemDetail + " / " + item.ItemDetail.Material + " / " + item.ItemDetail.Material.MaterialList + " / " + Utils.getCurrentTime());
            

            PackageItem pi = GetPackageItemByOwnerUserId(item.GeneralID);
            if (pi != null)
            {
                for (int i = 0, count = pi.Bags.Count; i < count; i++)
                {
                    if (pi.Bags[i].Response.InstanceID == item.InstanceID)
                    {
                        ItemSynthesizeMaterialResponse mat = null;
                        bool isUpgrade = false;
                        if (pi.Bags[i].Response.ItemDetail != null && pi.Bags[i].Response.ItemDetail.Material != null)
                        {
                            mat = pi.Bags[i].Response.ItemDetail.Material;
                            isUpgrade = pi.Bags[i].Response.ItemDetail.IsUpgrade;
                        }
                        pi.Bags[i].Response = item;
                        if (mat != null)
                        {
                            pi.Bags[i].Response.ItemDetail.Material = mat;
                            pi.Bags[i].Response.ItemDetail.IsUpgrade = isUpgrade;
                        }
                        CallUpdate(pi.Bags[i], UpdateType.Update);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 差异化更新用户背包数据
        /// </summary>
        /// <param name="items"></param>
        public void UpdateBagPackageItem(List<PlayerBagItemUpdateResponse> items)
        {
            foreach (PlayerBagItemUpdateResponse item in items)
            {
                UpdateBagPackageItem(item);
            }
        }

        /// <summary>
        /// 差异化更新用户背包数据
        /// </summary>
        /// <param name="item"></param>
        public void UpdateBagPackageItem(PlayerBagItemUpdateResponse item)
        {
            if (piPack != null && piPack.Bags != null)
            {
                int count = piPack.Bags.Count;
                for (int i = 0; i < count; i++)
                {
                    if (piPack.Bags[i].Response.Index == item.Index)
                    {
                        if (item.Nums == 0)
                        {
                            int itemId = piPack.Bags[i].Response.ItemId;
                            CallUpdate(piPack.Bags[i], UpdateType.Remove);
                            piPack.Bags.RemoveAt(i);
                            // 全部交叉检测是否可升级
                            bool isContain = false;
                            
                            foreach (GoodsItem good in piPack.Bags)
                            {
                                if (good.Response.ItemId == itemId)
                                {
                                    isContain = true;
                                    break;
                                }
                            }

                            if (!isContain)
                            {
                                foreach (PackageItem pii in items)
                                {
                                    if (pii.OwnerUserID != 0)
                                    {
                                        foreach (GoodsItem good in pii.Bags)
                                        {
                                            if (good.Response.ItemDetail.IsUpgrade)
                                            {
                                                checkGoodsItemInBodyUpgrade(good, true);
                                                //UpdatePackageItemDetailCanUpgrade(good.Response, piPack);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            piPack.Bags[i].Response.Nums = item.Nums;
                            CallUpdate(piPack.Bags[i], UpdateType.Update);
                        }
                        break;
                    }
                }
            }
        }

        public static int SortByType(BagResponse a, BagResponse b)
        {
            if (a.Type > b.Type) return 1;
            else if (a.Type < b.Type) return -1;
            return 0;
        }
        public static int SortByIndex(BagResponse a, BagResponse b)
        {
            if (a.Index > b.Index) return 1;
            else if (a.Index < b.Index) return -1;
            return 0;
        }
    }
}
