using UnityEngine;
using System.Collections;
using com.think.messages;

namespace com.think.data.cache.cd
{
    public class CDTimeItem : IUpdateItem {
        public CDTimeResponse Response { get; set; }

        /// <summary>
        /// �Ƿ��ǿͻ���˽��
        /// </summary>
        bool isPrivate = false;
        public bool IsPrivate { get { return isPrivate; } set { isPrivate = value; } }

        //�Ƿ����ʾ���������CD�б���
        bool isInCdList = true;
        public bool IsInCdList { get { return isInCdList; } set { isInCdList = value; } }

        public int CompareTo(object obj)
        {
            CDTimeItem other = obj as CDTimeItem;
            if (Response.Id == other.Response.Id)
            {
                return 0;
            }
            return -1;
        }

        public UpdateItemType GetUpdateItemType()
        {
            return UpdateItemType.CDTime;
        }
    }
}
