using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using com.think.messages;

namespace com.think.data.cache.friend
{
    /// <summary>
    /// ���컯��������
    /// </summary>
    public enum UpdateType : byte
    {
        /// <summary>
        /// ����
        /// </summary>
        Add = 1,
        /// <summary>
        /// ɾ��
        /// </summary>
        Remove = 2,
        /// <summary>
        /// ����
        /// </summary>
        Update = 3
    }

    public interface IFriendUpdater
    {
        byte getFriendType();
        void UpdateFriend(FriendResponse response, UpdateType type);
        void UpdateFriendList(List<FriendResponse> lists);
    } 
      
    public class FriendManager
    {
        private FriendManager() { }
        public static readonly FriendManager instance = new FriendManager();
        /// <summary>
        /// ��������
        /// </summary>
        List<FriendResponse> friendList = new List<FriendResponse>();
        /// <summary>
        /// ������
        /// </summary>
        List<FriendResponse> blackList = new List<FriendResponse>();
        List<IFriendUpdater> updaters = new List<IFriendUpdater>();

        public void regist(IFriendUpdater _updater, bool getValueNow)
        {
            if (!updaters.Contains(_updater))
            {
                updaters.Add(_updater);
                if (getValueNow)
                { 
                    _updater.UpdateFriendList(_updater.getFriendType() == 0 ? friendList : blackList);
                }
            }
        }

        public FriendResponse GetFriendByUserId(int userId)
        {
            foreach (FriendResponse fr in friendList)
            {
                if (fr.User_id == userId)
                {
                    return fr;
                }
            }
            return null;
        }

        public int FriendNum
        {
            get
            {
                return friendList.Count;
            }
        }

        public void unregist(IFriendUpdater _updater)
        {
            if (updaters.Contains(_updater)) updaters.Remove(_updater);
        }

        public void InitFriendList(List<FriendResponse> list, byte listType)
        {
            if (listType == 0) friendList = list;
            else if (listType == 1) blackList = list;
            foreach (IFriendUpdater icu in updaters)
            {
                if (icu.getFriendType() == listType)
                {
                    icu.UpdateFriendList(list);
                }
            }
        }

        UpdateType UpdateFriend(FriendResponse response, List<FriendResponse> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].User_id == response.User_id)
                {
                    list[i] = response;
                    return UpdateType.Update;
                }
            } 
            list.Add(response);
            return UpdateType.Add;
        }

        void RemoveFriend(FriendResponse response,List<FriendResponse> list)
        {
            foreach (FriendResponse fr in list) 
            {
                if (fr.User_id == response.User_id)
                {
                    list.Remove(fr);
                    break;
                }
            }
        }


        public FriendResponse Response
        {
            set
            {
                FriendResponse response = value; 
                UpdateType uType = UpdateType.Add;

                if (response.FriendType == 0)
                {
                    uType = UpdateFriend(response, friendList); //���������б�
                }
                else if (response.FriendType == 1) //�������ӵ�������
                {
                    uType = UpdateFriend(response, blackList); //�ȸ��º�����
                    RemoveFriend(response, friendList);//����������ں����б� ��ɾ�� 
                }
                else if (response.FriendType == 5)
                {
                    RemoveFriend(response, friendList);//����������ں����б� ��ɾ�� 
                }
                else if (response.FriendType == 6)
                {
                    RemoveFriend(response, blackList);//����������ں������б� ��ɾ�� 
                } 

                foreach (IFriendUpdater icu in updaters)
                {
                    if (isValidChatType(icu.getFriendType(), response))
                    {
                        if (response.FriendType == 5 || response.FriendType == 6 
                            || (response.FriendType == 1 && icu.getFriendType() == 0)) icu.UpdateFriend(response, UpdateType.Remove);
                        else icu.UpdateFriend(response, uType);
                    }
                }
            }
        }
         
        bool isValidChatType(byte fiendType, FriendResponse response)
        {
            return (fiendType == 0 && (response.FriendType == 0 || response.FriendType == 5 || response.FriendType == 1)) 
                || (fiendType == 1 && (response.FriendType == 1 || response.FriendType == 6));
        }
    }
}
