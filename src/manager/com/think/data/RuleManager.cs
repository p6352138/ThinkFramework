using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;

namespace com.think.data.rule
{
    public class RuleRecruitItem
    {
        /// <summary>
        /// ����ļ�佫����
        /// </summary>
        public int generalSum { get; set; }
        /// <summary>
        /// �ƹݽ����ȼ�
        /// </summary>
        public int buildingLevel { get; set; }
        string mTip;
        public string tip { set { mTip = value; } }

        /// <summary>
        /// ������ļʱ��ʾ����
        /// </summary>
        /// <returns></returns>
        public string getTip()
        {
            string t = mTip;
            if (t.IndexOf('#') != -1)
            {
                t = t.Replace("#", System.Convert.ToString(buildingLevel));
                t = t.Replace("%", System.Convert.ToString(generalSum));
            }
            return t;
        }
    }

    public class MiJiItem
    {
        public int miji_type { get; set; }
        public int[] ids { get; set; }
        public int[] miji_instanceID { get; set; }
        public string[] iconName{get;set;}
        public int[] miji_consume { get; set; }
        public string[] miji_name { get; set; }
        public string miji_resourse { get; set; }
        public int[] miji_use_lv { get; set; }
        public string[] miji_use_lv_name { get; set; }
    }

    public class AutoBuyItem
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
        public byte priceType { get; set; }
        public int priceValue { get; set; }
    }

    public class RuleManager
    {
        class Tag
        {
            public const string RESPONSE_JSON_FILE_NAME = "rule";

            public const string recruit = "recruit";
            public const string generalSum = "generalSum";
            public const string buildingLevel = "buildingLevel";
            public const string tip = "tip";

            public const string generalOrdnance = "generalOrdnance";
            public const string generalOrdnanceTrait = "generalOrdnanceTrait";
            public const string generalUpgrade = "generalUpgrade";
            public const string huaRongDao = "huaRongDao";

            public const string minPlunderMapId = "minPlunderMapId";
	        public const string bigPlunderValue = "bigPlunderValue";
	        public const string hugePlunderValue = "hugePlunderValue";

            public const string miji = "miji";
            public const string miji_id = "miji_id";
            public const string miji_instanceID = "miji_instanceID";
            public const string miji_icon = "miji_icon";
            public const string miji_type = "miji_type";
            public const string miji_consume = "miji_consume";
            public const string miji_name = "miji_name";
            public const string miji_resourse = "miji_resourse";
            public const string miji_use_lv = "miji_use_lv";
            public const string miji_use_lv_name = "miji_use_lv_name";

            public const string recruitGeneralTipMap = "recruitGeneralTipMap2";
            public const string playerLevel = "playerLevel";
            public const string generalType = "generalType";
            public const string generalStar = "generalStar";

            public const string bannerFire = "bannerFire";

            public const string openPay = "openPay";

            public const string autoBuyItem = "autoBuyItem",
                                itemBodyIndex = "itemBodyIndex",
                                itemId = "itemId",
                                itemName = "itemName",
                                priceType = "priceType",
                                priceValue = "priceValue";
        }

        private RuleManager() { load(); }
        public static readonly RuleManager instance = new RuleManager();

        List<RuleRecruitItem> ruleRecruitItems = new List<RuleRecruitItem>();
        readonly string defaultRecruitTip = "�����ƹݿ���ļ���ཫ��!";

        public int generalUpgradeLevel = 60;
        public int huaRongDaoLv = 70;
        public string generalOndnanceTip = "�ɹ�[00ffff]��3��[-]ʧ�ܷ�2��";
        public int generalOrdnanceTrait = 0; //ӵ��ר��������佫Ʒ�ʣ����ڴ�������ר����
        public int minPlunderMapId;
        public int bigPlunderValue;
        public int hugePlunderValue;
        public bool openPay = true;

        public int[] bannerFireGrade;

        public List<MiJiItem> mjs = new List<MiJiItem>();

        //�����佫��ļ��Ϣ List<>0λ����佫Ʒ�ʣ�1λ����佫�Ǽ���key���佫�ȼ�
        Dictionary<int, List<int>> mRecruiteGeneralTypeMap = new Dictionary<int, List<int>>();
        public Dictionary<int, List<int>> RecruiteGeneralTypeMap { get { return mRecruiteGeneralTypeMap; } }

        //�佫����װ���Զ������б�
        public Dictionary<int, AutoBuyItem> autoBuyItemMap = new Dictionary<int, AutoBuyItem>();

        public List<MiJiItem> GetMiJiList()
        {
           return mjs;
        }

        /// <summary>
        /// ��ȡ��ļ��һ���佫��Ҫ������ʾ
        /// </summary>
        /// <param name="nextGeneralSum">��һ�����佫����</param>
        /// <returns></returns>
        public string getRecruitNextGeneralTip(int nextGeneralSum)
        {
            foreach (RuleRecruitItem item in ruleRecruitItems)
            {
                if (item.generalSum == nextGeneralSum)
                {
                    return item.getTip();
                }
            }

            return defaultRecruitTip;
        }



        void load()
        {
            string text = com.think.manager.ISceneManager.Instance.versionController.loadText("rule");
            if (!string.IsNullOrEmpty(text))
            {
                JsonData jData = JsonMapper.ToObject(text);
                {
                    try
                    {
                        JsonData recruitJsonData = jData[Tag.recruit];
                        for (int i = 0, count = recruitJsonData.Count; i < count; i++)
                        {
                            RuleRecruitItem item = parseRecruitItem(recruitJsonData[i]);
                            ruleRecruitItems.Add(item);
                        }
                    }
                    catch (System.Exception) { }
                }
                {
                    try
                    {
                        generalUpgradeLevel = int.Parse(jData[Tag.generalUpgrade].ToString());
                    }
                    catch (System.Exception) { }

                    try
                    {
                        openPay = int.Parse(jData[Tag.openPay].ToString()) == 1;
                    }
                    catch (System.Exception) { }

                    try
                    {
                        generalOndnanceTip = jData[Tag.generalOrdnance].ToString();
                    }
                    catch (System.Exception) { }

                    try
                    {
                        generalOrdnanceTrait = int.Parse(jData[Tag.generalOrdnanceTrait].ToString());
                    }
                    catch (System.Exception) { }
                    
                    try
                    {
                        huaRongDaoLv = int.Parse(jData[Tag.huaRongDao].ToString());
                    }
                    catch (System.Exception) { }

                    try
                    {
                        JsonData mijiJsonData = jData[Tag.miji];
                        for (int i = 0, count = mijiJsonData.Count; i < count; i++)
                        {
                            MiJiItem item = parseMiJiItem(mijiJsonData[i]);
                            mjs.Add(item);
                        }
                    }
                    catch (System.Exception) { }

                    try
                    {
                        minPlunderMapId = int.Parse(jData[Tag.minPlunderMapId].ToString());
                        bigPlunderValue = int.Parse(jData[Tag.bigPlunderValue].ToString());
                        hugePlunderValue = int.Parse(jData[Tag.hugePlunderValue].ToString());
                    }
                    catch (System.Exception) { }
                }
                {
                    try
                    {
                        JsonData rgData = jData[Tag.recruitGeneralTipMap];
                        for (int i = 0, count = rgData.Count; i < count; i++)
                        {
                            int playerLevel = int.Parse(rgData[i][Tag.playerLevel].ToString());
                            int generalType = int.Parse(rgData[i][Tag.generalType].ToString());
                            int generalStar = int.Parse(rgData[i][Tag.generalStar].ToString());
                            List<int> general = new List<int>();
                            general.Add(generalType);
                            general.Add(generalStar);
                            mRecruiteGeneralTypeMap.Add(playerLevel, general);
                        }
                    }
                    catch (System.Exception) { }
                }
                try
                {
                    string[] s_bannerFire = jData[Tag.bannerFire].ToString().Split(',');
                    int count = s_bannerFire.Length;
                    bannerFireGrade = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        bannerFireGrade[i] = int.Parse(s_bannerFire[i]);
                    }
                }
                catch (System.Exception) { }

                try
                {
                    JsonData itemDatas = jData[Tag.autoBuyItem];
                    int cl = itemDatas.Count;
                    for (int i = 0; i < cl; i++)  
                    {
                        JsonData item = itemDatas[i];
                        int itemBodyIndex = System.Convert.ToInt32(item[Tag.itemBodyIndex].ToString().Trim());
                        int itemId = int.Parse(item[Tag.itemId].ToString());
                        string itemName = item[Tag.itemName].ToString();
                        byte priceType = byte.Parse(item[Tag.priceType].ToString());
                        int priceValue = int.Parse(item[Tag.priceValue].ToString());
                        AutoBuyItem abi = new AutoBuyItem();
                        abi.itemId = itemId;
                        abi.itemName = itemName;
                        abi.priceType = priceType;
                        abi.priceValue = priceValue;
                        autoBuyItemMap.Add(itemBodyIndex, abi);
                    }
                }
                catch (System.Exception) { }

                jData.Clear();
                jData = null;
            }
        }

        private MiJiItem parseMiJiItem(JsonData jsonData)
        {
            MiJiItem item = new MiJiItem();
            try
            { 
                item.miji_type = int.Parse(jsonData[Tag.miji_type].ToString());
                string[] ids = jsonData[Tag.miji_id].ToString().Trim().Split(',');

                int count = ids.Length;
                int[] idds = new int[count];
                for (int i = 0; i < count; i++)
                {
                    idds[i] = int.Parse(ids[i]);
                }
                item.ids = idds;


                string[] id2s = jsonData[Tag.miji_instanceID].ToString().Trim().Split(',');
                count = id2s.Length;
                int[] miji_instanceID = new int[count];
                for (int i = 0; i < count; i++)
                {
                    miji_instanceID[i] = int.Parse(id2s[i]);
                }
                item.miji_instanceID = miji_instanceID;

                string[] iconName = jsonData[Tag.miji_icon].ToString().Trim().Split(',');
                item.iconName = iconName;

                string[] s_consume = jsonData[Tag.miji_consume].ToString().Trim().Split(',');
                count = s_consume.Length;
                int[] miji_consume = new int[count];
                for (int i = 0; i < count; i++)
                {
                    miji_consume[i] = int.Parse(s_consume[i]);
                }
                item.miji_consume = miji_consume;

                string[] mijiName = jsonData[Tag.miji_name].ToString().Trim().Split(',');
                item.miji_name = mijiName;

                item.miji_resourse = jsonData[Tag.miji_resourse].ToString();

                if (jsonData.Keys.Contains(Tag.miji_use_lv))
                {
                    string[] s_use_lv = jsonData[Tag.miji_use_lv].ToString().Trim().Split(',');
                    count = s_use_lv.Length;
                    int[] miji_use_lv = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        miji_use_lv[i] = int.Parse(s_use_lv[i]);
                    }
                    item.miji_use_lv = miji_use_lv;
                }

                if (jsonData.Keys.Contains(Tag.miji_use_lv_name))
                {
                    item.miji_use_lv_name = jsonData[Tag.miji_use_lv_name].ToString().Trim().Split(',');
                } 
            }
            catch (System.Exception)
            {
            }
            return item;
        }

        RuleRecruitItem parseRecruitItem(JsonData jData)
        {
            RuleRecruitItem item = new RuleRecruitItem();
            item.generalSum = int.Parse(jData[Tag.generalSum].ToString());
            item.buildingLevel = int.Parse(jData[Tag.buildingLevel].ToString());
            item.tip = jData[Tag.tip].ToString();

            return item;
        }
    }
}
