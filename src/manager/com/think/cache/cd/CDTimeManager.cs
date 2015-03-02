using System;
using UnityEngine;
using System.Collections.Generic;
using com.think.io;
using com.think.messages;

namespace com.think.data.cache.cd
{
    public interface ICDUpdater : IUpdater { }

    public class CDTimeManager:IManager, ISecondUpdate
    {
        private CDTimeManager()
        {
        }
        public static readonly CDTimeManager instance = new CDTimeManager();

        /// <summary>
        /// 客户端版本生成一个天下征收CD
        /// </summary>
        void createCollectCDTime()
        {
            CDTimeItem cti = new CDTimeItem();
            CDTimeResponse response = new CDTimeResponse();
            response.Id = 999;
            response.Type = 255;
            response.CdTime = 0;
            response.State = 0;

            cti.Response = response;
            cti.IsPrivate = true;

            Add(cti);
        }

        public void InitCdTimeList(CDTimeListResponse listResponse)
        {
            List<IUpdateItem> iis = new List<IUpdateItem>();

            foreach (CDTimeResponse response in listResponse.CdTimeResponseList)
            {
                //Logger.Log(response);

                CDTimeItem item = new CDTimeItem();
                item.Response = response;
                iis.Add(item);
            }

            Init(iis);
            createCollectCDTime();
        }

        /// <summary>
        /// 根据CD时间的类型查找
        /// </summary>
        /// <param name="type">1=征战，2=征收，3=突飞 ,4=训练, 5=建筑，6=添加建筑队列,7=征义兵，8=保护,9=迁移，10=鼓舞 14=新pve3重置</param>
        /// <returns></returns>
        public CDTimeResponse GetCDTimeResponseByType(byte type)
        {
            foreach (IUpdateItem item in items)
            {
                if (item.GetUpdateItemType() == UpdateItemType.CDTime)
                {
                    CDTimeItem cd = item as CDTimeItem;
                    if (cd.Response.Type == type)
                    {
                        return cd.Response;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 根据CD时间的类型查找
        /// </summary>
        /// <param name="type">1=征战，2=征收，3=突飞 ,4=训练, 5=建筑，6=添加建筑队列,7=征义兵，8=保护,9=迁移，10=鼓舞</param>
        /// <returns></returns>
        public List<CDTimeResponse> GetCDTimeListResponseByType(byte type) 
        {
            List<CDTimeResponse> cdList = new List<CDTimeResponse>();
            foreach (IUpdateItem item in items)
            {
                if (item.GetUpdateItemType() == UpdateItemType.CDTime)
                {
                    CDTimeItem cd = item as CDTimeItem;
                    if (cd.Response.Type == type)
                    {
                        cdList.Add(cd.Response);
                    }
                }
            } 
            return cdList.Count > 0 ? cdList : null;
        }

        /// <summary>
        /// 根据cd时间类型看是否有可用cd队列
        /// </summary>
        /// <param name="type">1=征战，2=征收，3=突飞 ,4=训练, 5=建筑，6=添加建筑队列,7=征义兵，8=保护,9=迁移，10=鼓舞</param>
        /// <returns></returns>
        public bool CanUseCDTimeByType(byte type)
        {
            foreach (IUpdateItem item in items)
            {
                if (item.GetUpdateItemType() == UpdateItemType.CDTime)
                {
                    CDTimeItem cd = item as CDTimeItem;
                    if (cd.Response.Type == type && cd.Response.IsCanUse)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 更新CD时间
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cdTime"></param>
        public void UpdateCDTime(byte type, int cdTime)
        {
            foreach (IUpdateItem item in items)
            {
                if (item.GetUpdateItemType() == UpdateItemType.CDTime)
                {
                    CDTimeItem cd = item as CDTimeItem;
                    //Logger.Warning("cd::::" + cd.Response + " / " + type + " / " + Time.time);
                    if (cd.Response.Type == type)
                    {
                        cd.Response.CdTime = cdTime;
                        CallUpdate(cd, UpdateType.Update);
                        break;
                    }
                }
            }
        }

        public void RemoveCDTime(byte type)
        {
            foreach (IUpdateItem item in items)
            {
                if (item.GetUpdateItemType() == UpdateItemType.CDTime)
                {
                    CDTimeItem cd = item as CDTimeItem;
                    if (cd.Response.Type == type)
                    {
                        CallUpdate(cd, UpdateType.Remove);
                        items.Remove(item);
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// 更新CD时间
        /// </summary>
        /// <param name="responseText"></param>
        public void UpdateCDTimeResponse(CDTimeResponse response)
        {
            if (response != null)
            {
                CDTimeItem item = new CDTimeItem();
                item.Response = response;
                Update(item);
            }
        }

        /// <summary>
        /// 更新CD时间
        /// </summary>
        /// <param name="responseText"></param>
        public void UpdateCDTimeResponse(CDTimeResponse response, bool isInCdList) 
        {
            CDTimeItem item = new CDTimeItem();
            item.IsInCdList = isInCdList;
            item.Response = response;
            Update(item);
        }

        /// <summary>
        /// 删除CD时间
        /// </summary>
        /// <param name="responseText"></param>
        public void RemoveCDTimeResponse(CDTimeResponse response)
        {
            CDTimeItem item = new CDTimeItem();
            item.Response = response;
            Remove(item);
        }

        public void OnUpdate()
        {
            foreach (IUpdateItem item in items)
            {
                if (item.GetUpdateItemType() == UpdateItemType.CDTime)
                {
                    CDTimeItem cdItem = item as CDTimeItem;
                                        
                    if (cdItem.Response.CdTime > 0)
                    {
                        cdItem.Response.CdTime--;
                        if (cdItem.Response.CdTime == 0)
                        {
                            if (cdItem.Response.State == 0 && !cdItem.IsPrivate)
                            {
                                SendResetCDRequest(cdItem.Response);
                            }
                            else if (cdItem.Response.State == 1)
                            {
                                Remove(item);
                            }
                            else if (cdItem.Response.State == 0 && cdItem.IsPrivate)
                            {
                                Update(item);
                            }
                        }
                        else
                        {
                            Update(item);
                        }
                    }
                }
            }
        }

        void SendResetCDRequest(CDTimeResponse response)
        {
            RequestWrapper rw;
            RequestHelper.GetCDTimeRequest(out rw, 2, response.Id);
            QueueCache.instance.sendRequest(rw);
        }
    }
}
