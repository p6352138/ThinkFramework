using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using com.think.messages;

namespace com.think.manager.guide
{
    public interface HandleGuideListener
    {
        void handleGuide(int guideId);
    }

    public interface GuideNotify
    {
        void LockState(float time);
        void regist();
        void unregist();
        int getFunctionId();
        void SetState(byte state);
        void SetState(byte state, float time);
        void SetState(byte state, float time, bool isClientControl);
        void setGuideItem(GuideItem item);
    }

    /// <summary>
    /// ָ���Ĵ�������
    /// </summary>
    public class Condition
    {
        public readonly static byte CI_LEVEL = 0, CI_VIP = 1, CI_TASK_ID = 2, CI_TASK_STATE = 3, CI_GENERAL_ID = 4, CI_PRE_ID = 5, CI_GENERAL_PASS = 6;
        
        /// <summary>
        /// ��ҵȼ�
        /// </summary>
        private short mLevel;
        public short level { get { return mLevel; } set { mLevel = value; if (mLevel == 0) actived[CI_LEVEL] = true; } }

        /// <summary>
        /// Vip�ȼ�
        /// </summary>
        private byte mVip;
        public byte vip { get { return mVip; } set { mVip = value; if (mVip == 0) actived[CI_VIP] = true; } }

        /// <summary>
        /// ������
        /// </summary>
        private int mTaskId;
        public int taskId { get { return mTaskId; } set { mTaskId = value; if (mTaskId == 0) actived[CI_TASK_ID] = true; } }

        /// <summary>
        /// ����״̬
        /// </summary>
        private byte mTaskState;
        public byte taskState { get { return mTaskState; } set { mTaskState = value; if (mTaskId == 0 || (mTaskId != 0 && mTaskState == 0)) actived[CI_TASK_STATE] = true; } }

        /// <summary>
        /// �ؿ��佫���
        /// </summary>
        private int mGeneralId;
        public int generalId { get { return mGeneralId; } set { mGeneralId = value; if (mGeneralId == 0) actived[CI_GENERAL_ID] = true; } }

        /// <summary>
        /// �ؿ��佫�Ƿ�ͨ��״̬ 1-Ӯ 2-��
        /// </summary>
        private byte mGneralState;
        public byte generalState { get { return mGneralState; } set { mGneralState = value; if (mGeneralId == 0 || (mGeneralId != 0 && mGneralState == 0)) actived[CI_GENERAL_PASS] = true; } }

        /// <summary>
        /// ǰ��ָ�����
        /// </summary>
        private int mPreId;
        public int preId { get { return mPreId; } set { mPreId = value; if (mPreId == 0) actived[CI_PRE_ID] = true; } }

        /// <summary>
        /// �Ƿ���������
        /// </summary>
        bool[] actived = new bool[7];

        /// <summary>
        /// �Ƿ�ɼ���
        /// </summary>
        public bool IsActive
        {
            get
            {
                foreach (bool flag in actived)
                {
                    if (!flag) return false;
                }
                return true;
            }
        }

        public bool SetActive(byte index)
        {
            actived[index] = true;
            return IsActive;
        }

        public bool GetActive(byte index)
        {
            return actived[index];
        }

        public void SetActive2(byte index)
        {
            actived[index] = true;
        }

        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();

            builder.Append("mLevel").Append(mLevel).Append(",");
            builder.Append("mVip").Append(mVip).Append(",");
            builder.Append("mTaskId").Append(mTaskId).Append(",");
            builder.Append("mTaskState").Append(mTaskState).Append(",");
            builder.Append("mGeneralId").Append(mGeneralId).Append(",");
            builder.Append("mGneralState").Append(mGneralState).Append(",");
            builder.Append("mPreId").Append(mPreId).Append(",");
            builder.Append("IsActive").Append(IsActive).Append(",");
            return builder.ToString();
        }
    }

    /// <summary>
    /// ָ����
    /// </summary>
    public class GuideItem
    {
        /// <summary>
        /// ָ�����
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ��Ӧ�Ĺ��ܱ��
        /// </summary>
        public int OperationId { get; set; }
        /// <summary>
        /// ָ������ 1�ɼ�����;2����;3��ʾ��˸;4��ʾ��Ϣ;5npc˵����6���˵����7ͼ��8�֣�9���µ�ͼ;0����;10bossս;11�϶�ָ��
        /// </summary>
        public byte Type { get; set; }
        /// <summary>
        /// ָ������������
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// ָ����ͼ��
        /// </summary>
        public int Icon { get; set; }
        /// <summary>
        /// ָ����ʾ��λ��
        /// </summary>
        public byte Postion { get; set; }
        /// <summary>
        /// ��ת������
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// ǰ�ù��ܱ��
        /// </summary>
        public int PreOperationId { get; set; }
        /// <summary>
        /// ����ָ�����
        /// </summary>
        public int FinishOperationid { get; set; }

        /// <summary>
        /// �Զ��رյ�ʱ��(ms) 0-���Զ��ر�
        /// </summary>
        public int Delay { get; set; }

        /// <summary>
        /// �Ƿ���Ҫ�洢
        /// </summary>
        public byte IsSave { get; set; }

        public Condition condition { get; set; }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("GuideItem::(id=" + Id + ", OperationId=" + OperationId + ", Type=" + Type + ", Uid=" + Uid + ", Condition=" + condition.ToString() + ", msg=" + Message + ")");
            return sb.ToString();
        }
    }

    /// <summary>
    /// ָ��������
    /// </summary>
    public class GuideManager
    {
        public bool mIsDebug = true;
        public bool IsDebug
        {
            get { return mIsDebug; }
            set { mIsDebug = value; }
        }

        private GuideManager() { }
        public static readonly GuideManager instance = new GuideManager();


        List<HandleGuideListener> handleList = new List<HandleGuideListener>();

        /// <summary>
        /// �����ָ��
        /// </summary>
        List<GuideItem> items = new List<GuideItem>();

        /// <summary>
        /// ��ǰ�����ָ��
        /// </summary>
        List<GuideItem> actives = new List<GuideItem>();

        /// <summary>
        /// ��ʱ������Ҫ�����ָ��
        /// </summary>
        List<GuideItem> tempActiveList = new List<GuideItem>();

        /// <summary>
        /// �Ѿ���������ָ�����
        /// </summary>
        List<int> triggeredIds = new List<int>();

        /// <summary>
        /// ���ܿ���״̬
        /// </summary>
        Dictionary<int, byte> functions = new Dictionary<int, byte>();

        /// <summary>
        /// ���浱ǰ��Ĺ���ָ��
        /// </summary>
        List<GuideNotify> notifies = new List<GuideNotify>();

        /// <summary>
        /// ���浱ǰ�Ĺ���ָ���ȴ�����������ɺ�ָ�
        /// </summary>
        GuideNotify cachedNotify;
        GuideItem cachedItem;
        bool isCached = false;

        #region load operation
        char _split1 = '\n';
        char _split2 = ',';
        public char SPLIT1
        {
            get { return _split1; }
            set { _split1 = value; }
        }
        public char SPLIT2
        {
            get { return _split2; }
            set { _split2 = value; }
        }
        //char[] SPLIT1 = new char[] { '\n' };
        //char[] SPLIT2 = new char[] { ',' };

        public void registHandle(HandleGuideListener listener)
        {
            if (!handleList.Contains(listener))
            {
                handleList.Add(listener);
            }
        }

        public void unregistHandle(HandleGuideListener listener)
        {
            if (handleList.Contains(listener))
            {
                handleList.Remove(listener);
            }
        }

        public void init()
        {
            cachedNotify = null;
            cachedItem = null;
            functions.Clear();
            triggeredIds.Clear();
            tempActiveList.Clear();
            actives.Clear();
            items.Clear();

            string text = com.think.manager.ISceneManager.Instance.versionController.loadText("guide");
            if (!string.IsNullOrEmpty(text))
            {
                loadOperation(text);
            }
        }

        /// <summary>
        /// ����·����ָ������
        /// </summary>
        /// <param name="path"></param>
        public void loadOperation(string text)
        {
            string[] sas = text.Split(SPLIT1);
            foreach (string s in sas)
            {
                GuideItem item = new GuideItem();
                string[] sts = s.Split(SPLIT2);
                try
                {
                    int id = System.Convert.ToInt32(sts[0]);
                    int opId = System.Convert.ToInt32(sts[1]);
                    byte type = System.Convert.ToByte(sts[4]);
                    int preOpId = System.Convert.ToInt32(sts[10]);
                    string message = string.IsNullOrEmpty(sts[11]) ? null : sts[11];
                    int icon = System.Convert.ToInt32(sts[12]);
                    byte postion = System.Convert.ToByte(sts[13]);
                    int fid = System.Convert.ToInt32(sts[14]);
                    string uid = sts[15];
                    byte isSave = System.Convert.ToByte(sts[17]);
                    int delay = System.Convert.ToInt32(sts[19]);

                    item.Id = id;
                    item.OperationId = opId;
                    item.Type = type;
                    item.PreOperationId = preOpId;
                    item.Message = message;
                    item.Icon = icon;
                    item.Postion = postion;
                    item.Uid = uid;
                    item.FinishOperationid = fid;
                    item.IsSave = isSave;
                    item.Delay = delay;

                    short level = System.Convert.ToInt16(sts[5]);
                    byte vip = System.Convert.ToByte(sts[6]);
                    int taskId = System.Convert.ToInt32(sts[7]);
                    byte taskState = System.Convert.ToByte(sts[3]);
                    int generalId = System.Convert.ToInt32(sts[8]);
                    byte generalState = System.Convert.ToByte(sts[18]);
                    int preId = System.Convert.ToInt32(sts[9]);

                    Condition c = new Condition();
                    c.level = level;
                    c.vip = vip;
                    c.taskId = taskId;
                    c.taskState = taskState;
                    c.generalId = generalId;
                    c.generalState = generalState;
                    c.preId = preId;
                    item.condition = c;

                    items.Add(item);
                }
                catch (System.Exception e)
                {
                    if (mIsDebug)
                    {
                        Logger.Warning("Guide error:" + e.Message + " / " + s);
                    }
                }
            }
        }
        #endregion

        #region trigger
        /// <summary>
        /// �������ʱ�ж��Ƿ񴥷�ָ��
        /// </summary>
        /// <param name="level"></param>
        public void setPlayerLevel(short level)
        {
            bool flag = false;
            foreach (GuideItem item in items)
            {
                if (!item.condition.GetActive(Condition.CI_LEVEL) && item.condition.level <= level)
                {
                    if (item.condition.SetActive(Condition.CI_LEVEL))
                    {
                        tempActiveList.Add(item);
                        flag = true;
                    }
                }
            }
            if (flag) addToActiveList();
        }
        
        /// <summary>
        /// VIP�ȼ�����ʱ�ж��Ƿ񴥷�ָ��
        /// </summary>
        /// <param name="vip"></param>
        public void setVipLevel(byte vip)
        {
            bool flag = false;
            foreach (GuideItem item in items)
            {
                if (!item.condition.GetActive(Condition.CI_VIP) && item.condition.vip <= vip)
                {
                    if (item.condition.SetActive(Condition.CI_VIP))
                    {
                        tempActiveList.Add(item);
                        flag = true;
                    }
                }
            }
            if (flag) addToActiveList();
        }

        /// <summary>
        /// ������ȸ���ʱ�ж��Ƿ񴥷�ָ��
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="state"></param>
        public void setTask(int taskId, byte state)
        {
            if (mIsDebug)
            {
                Logger.Log("setTask::::::taskId:" + taskId + " / state:" + state + " / " + TFUtils.getCurrentTime());
            }
            bool flag = false;
            int lastTaskId = 0;
            foreach (GuideItem item in items)
            {
                if (item.condition.taskId == taskId && item.condition.taskState == state)
                {
                    item.condition.SetActive2(Condition.CI_TASK_ID);
                    item.condition.SetActive2(Condition.CI_TASK_STATE);
                    if (item.condition.IsActive)
                    {
                        if (lastTaskId < item.condition.taskId) lastTaskId = item.condition.taskId;
                        tempActiveList.Add(item);
                        flag = true;
                    }
                }
            }

            List<GuideItem> dels = new List<GuideItem>();
            foreach (GuideItem item in actives)
            {
                if (item.condition.taskId > 0 && item.condition.taskId < taskId && item.Id < lastTaskId)
                {
                    dels.Add(item);
                }
            }
            if (dels.Count > 0)
            {
                for (int i = 0, count = dels.Count; i < count; i++)
                {
                    actives.Remove(dels[i]);
                }
                dels.Clear();
            }
            dels = null;

            if (flag) addToActiveList();
        }

        /// <summary>
        /// սʤ�������˺��ж��Ƿ񴥷�ָ��
        /// </summary>
        /// <param name="generalId"></param>
        public void setGeneralId(int generalId, byte generalState)
        {
            List<GuideItem> dels = new List<GuideItem>();
            foreach (GuideItem item in actives)
            {
                if (item.condition.generalId > 0 && item.condition.generalId < generalId)
                {
                    dels.Add(item);
                }
            }
            if (dels.Count > 0)
            {
                for (int i = 0, count = dels.Count; i < count; i++)
                {
                    actives.Remove(dels[i]);
                }
                dels.Clear();
            }
            dels = null;

            bool flag = false;
            foreach (GuideItem item in items)
            {
                //Logger.Log(item + " / " + item.condition.GetActive(Condition.CI_GENERAL_ID));
                if (item.condition.generalId == generalId && item.condition.generalState == generalState)
                {
                    item.condition.SetActive2(Condition.CI_GENERAL_ID);
                    item.condition.SetActive2(Condition.CI_GENERAL_PASS);
                    if (item.condition.IsActive)
                    {
                        tempActiveList.Add(item);
                        flag = true;
                    }
                }
            }
            if (flag) addToActiveList();
        }

        /// <summary>
        /// �������ǰ��ָ���ı���ж��Ƿ񴥷�ָ��
        /// </summary>
        /// <param name="preId"></param>
        public void setPreId(int preId)
        {
            bool flag = false;
            foreach (GuideItem item in items)
            {
                if (!item.condition.GetActive(Condition.CI_PRE_ID) && item.condition.preId == preId)
                {
                    if (item.condition.SetActive(Condition.CI_PRE_ID))
                    {
                        //Logger.Log("active guide item by preid::::" + item);
                        tempActiveList.Add(item);
                        flag = true;
                    }
                }
            }
            if (flag) addToActiveList();
        }

        /// <summary>
        /// ��ӵ������ָ���б�
        /// </summary>
        void addToActiveList()
        {
            foreach (GuideItem item in tempActiveList)
            {
               // Logger.Log("addToActiveList:::::::" + item);
                actives.Add(item);
                items.Remove(item);

                checkGuide(item);
            }
            tempActiveList.Clear();
        }

        /// <summary>
        /// ����ָ����ָ����ţ�����С�ڵ���ָ����ŵ�ָ��
        /// </summary>
        /// <param name="gid"></param>
        public void activeById(int gid)
        {
            bool flag = false;
            foreach (GuideItem item in items)
            {
                if (item.Id <= gid)
                {
                    flag = true;
                    tempActiveList.Add(item);
                }
                else break;
            }
            if (flag) addToActiveList();
        }

        /// <summary>
        /// ��¼������Ϸ�������׸�ָ����ǰ��ָ�����Ϊ0
        /// </summary>
        public void loginSetPreId(int preId)
        {
            bool flag = false;
            foreach (GuideItem item in items)
            {
                
                if (item.Id > preId && item.condition.preId != 0 && item.condition.preId <= preId)
                {
                    item.condition.preId = 0;

                    if (IsDebug)
                    {
                        Logger.Log(item);
                    }

                    if (item.condition.IsActive)
                    {
                        if (IsDebug)
                        {
                            Logger.Log("active=" + item);
                        }
                        tempActiveList.Add(item);
                        flag = true;
                    }

                    break;
                }
            }
            if (flag) addToActiveList();
        }
        #endregion

        #region regist/unregist notify
        /// <summary>
        /// ע�Ṧ�ܰ�ť
        /// </summary>
        /// <param name="notify"></param>
        public void regist(GuideNotify notify)
        {
            if (!notifies.Contains(notify))
            {
                notify.regist();
                notifies.Add(notify);
            }

            checkNotify(notify);
        }

        /// <summary>
        /// ע�����ܰ�ť
        /// </summary>
        /// <param name="notify"></param>
        public void unregist(GuideNotify notify)
        {
            if (notifies.Contains(notify))
            {
                notify.unregist();
                notifies.Remove(notify);
            }
        }
        #endregion

        #region init function state
        /// <summary>
        /// ��ʼ��ָ�����ܿ���״̬
        /// </summary>
        /// <param name="gid"></param>
        public void initFunctionState(int gid)
        {
            functions.Clear();

            foreach (GuideItem item in items)
            {
                if (item.Id <= gid)
                {
                    if (item.Type < 4)
                    {
#if UNITY_EDITOR
                        //Logger.Log("set function state::::id:" + item.Id + " / operationId:" + item.OperationId + " / " + item.Type + " / " + Time.time);
#endif
                        if (functions.ContainsKey(item.OperationId)) functions[item.OperationId] = item.Type;
                        else functions.Add(item.OperationId, item.Type);
                    }
                }
                else
                {
                    if (item.Type == 2)
                    {
                        if (!functions.ContainsKey(item.OperationId))
                        {
#if UNITY_EDITOR
                            //Logger.Log("set function state::::" + item.Id + " / opid"+ item.OperationId + " / 0 " + " / " + Time.time);
#endif                            
                            functions.Add(item.OperationId, 0);
                        }
                    }
                }
            }
        }
        #endregion

        #region check notify
        /// <summary>
        /// ���ָ���Ƿ�ɱ�����
        /// </summary>
        /// <param name="item"></param>
        void checkGuide(GuideItem item)
        {
#if UNITY_EDITOR
            //Logger.Log("GuideManager:::::checkGuide::::" + item + " / " + isHandle(item.PreOperationId) + " / " + Time.time);
#endif
            if (isHandle(item.PreOperationId))
            {
                GuideNotify notify = findNotify(item.OperationId);
                if (item.Type < 4)
                {
                    if (item.IsSave == 1)
                    {
                        saveGuide(item);
                    }

                    updateFunctionState(item.OperationId, item.Type);
                    if (notify != null) notify.SetState(item.Type);

                    actives.Remove(item);
                }
                else if (notify != null && (item.Type == 4 || item.Type == 11))
                {
                    notify.setGuideItem(item);
                }
                else if (item.Type > 4 && item.Type != 11)
                {
                    activeFunctionGuide(null, item);
                }
            }
        }

        /// <summary>
        /// ��⹦�ܰ�ť�Ƿ�ָ������
        /// </summary>
        /// <param name="notify"></param>
        public void checkNotify(GuideNotify notify)
        {
#if UNITY_EDITOR
            Logger.Log("GuideManager:::::checkNotify:" + notify  + " / " + Time.time);
#endif
            // ��⹦�ܿ���״̬
            {
                byte state;
                if (functions.TryGetValue(notify.getFunctionId(), out state))
                {
                    notify.SetState(state);
                }
            }

            // ���ָ��
            if (actives.Count > 0)
            {
                GuideItem delete = null;
                foreach (GuideItem item in actives)
                {
                    Logger.Log("GuideItem::::::" + item + " / " + notify.getFunctionId());
                    if (item.OperationId == notify.getFunctionId() && isHandle(item.PreOperationId))
                    {
                        Logger.Log("checkNotify::::::" + item);
                        if (item.Type < 4)
                        {
                            if (item.IsSave == 1)
                            {
                                saveGuide(item);
                            }

                            updateFunctionState(item.OperationId, item.Type);
                            notify.SetState(item.Type);
                            delete = item;
                        }
                        else if (item.Type == 4 || item.Type == 11)
                        {
                            notify.setGuideItem(item);
                        }
                        else if (item.Type > 4 && item.Type != 11)
                        {
                            activeFunctionGuide(null, item);
                        }
                        break;
                    }
                }
                if (delete != null)
                {
                    actives.Remove(delete);
                    checkNotify(notify);
                }
            }
        }

        /// <summary>
        /// �ⲿ�������ù���״̬
        /// </summary>
        /// <param name="functionId"></param>
        /// <param name="state"></param>
        public void setFunctionStateByOnline(byte state,int functionId)
        {
            if (functions.ContainsKey(functionId))
            {
                functions[functionId] = state;
             }
            else
            {
                functions.Add(functionId, state);
             }
            foreach (GuideNotify notify in notifies)
            {
                 if (notify.getFunctionId() == functionId)
                { 
                    notify.SetState(state); 
                    break;
                }
            }
        }

        /// <summary>
        /// ���¹��ܿ���״̬
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        void updateFunctionState(int id, byte state)
        {
            if (functions.ContainsKey(id)) functions[id] = state;
            else functions.Add(id, state);
        }

        /// <summary>
        /// ��ȡ���ܰ�ť��״̬
        /// </summary>
        /// <param name="notify"></param>
        /// <returns></returns>
        public byte getFunctionState(GuideNotify notify)
        {
            byte state;
            if (functions.TryGetValue(notify.getFunctionId(), out state)) return state;
            return 99;
        }

        /// <summary>
        /// ��ȡ���ܰ�ť��״̬
        /// </summary>
        /// <param name="functionId"></param>
        /// <returns></returns>
        public byte getFunctionState(int functionId)
        {
            byte state;
            if (functions.TryGetValue(functionId, out state)) return state;
            return 99;
        }

        /// <summary>
        /// ���ù��ܰ�ť��״̬
        /// </summary>
        /// <param name="functionId"></param>
        /// <param name="state"></param>
        /// <param name="duration"></param>
        public void setFunctionState(int functionId, byte state, float duration)
        {
            foreach (GuideNotify notify in notifies)
            {
                if (notify.getFunctionId() == functionId)
                {
                    notify.SetState(state, duration);
                    break;
                }
            }
        }

        /// <summary>
        /// ���ù��ܰ�ť��״̬
        /// </summary>
        /// <param name="functionId"></param>
        /// <param name="state"></param>
        /// <param name="duration"></param>
        /// <param name="isClientControl">�Ƿ��пͻ�����ȫ����</param>
        public void setFunctionState(int functionId, byte state, float duration, bool isClientControl)
        {
            foreach (GuideNotify notify in notifies)
            {
                if (notify.getFunctionId() == functionId)
                {
                    notify.SetState(state, duration, isClientControl);
                    break;
                }
            }
        }
        /// <summary>
        /// �����ָ��
        /// </summary>
        /// <param name="notify"></param>
        /// <param name="item"></param>
        void activeFunctionGuide(GuideNotify notify, GuideItem item)
        {
            if (com.think.manager.ISceneManager.Instance.IsLoading)
            {
                isCached = true;
                cachedNotify = notify;
                cachedItem = item;
                com.think.manager.ISceneManager.Instance.IsCallBackFunctionManagerByLoaded = true;
            }
            else if (notify != null)
            {
                notify.setGuideItem(item);
            }
            else
            {
                com.think.manager.ISceneManager.Instance.SceneManager.activeGuideView(item, null);
            }
        }

        /// <summary>
        /// �����������Ž����������ָ��
        /// </summary>
        public void processCachedFunctionGuide()
        {
            if (isCached)
            {
                isCached = false;
                ISceneManager.Instance.IsCallBackFunctionManagerByLoaded = false;
                if (cachedNotify != null) cachedNotify.setGuideItem(cachedItem);
                else activeGuideView(cachedItem, null, null, false);
            }
        }

        /// <summary>
        /// �������ָ��
        /// </summary>
        /// <param name="item"></param>
        void activeGuideView(GuideItem item, GameObject eventReceiver, string functionName, bool isOut)
        {
            ISceneManager.Instance.SceneManager.activeGuideView(item, eventReceiver, functionName, isOut);
        }

        /// <summary>
        /// ����ָ�����ܱ�Ų��ҹ��ܰ�ť
        /// </summary>
        /// <param name="functionId"></param>
        /// <returns></returns>
        public GuideNotify findNotify(int functionId)
        {
            foreach (GuideNotify notify in notifies)
            {
                if (notify.getFunctionId() == functionId) return notify;
            }
            return null;
        }
        /// <summary>
        /// ���ָ���Ƿ񱻴�����
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        bool isHandle(int gid)
        {
            return gid == 0 || triggeredIds.Contains(gid);
        }
        #endregion

        #region handle guide
        /// <summary>
        /// ָ����Ӧ����
        /// </summary>
        /// <param name="item"></param>
        public void handleGuide(GuideItem item)
        {
            actives.Remove(item);

            if (!triggeredIds.Contains(item.Id)) triggeredIds.Add(item.Id);

            setPreId(item.Id);

            if (item.IsSave == 1)
            {
                saveGuide(item);
            }

            if (handleList.Count > 0)
            {
                foreach (HandleGuideListener lis in handleList) lis.handleGuide(item.Id);
            }

            checkNext(item.Id);
        }

        public void handleGuide(int id)
        {
            for (int i = 0, count = actives.Count; i < count; i++)
            {
                if (actives[i].Id == id)
                {
                    handleGuide(actives[i]);
                    break;
                }
            }
        }	

        public bool handleGuide(GuideItem item, GameObject eventReceiver, string functionName, bool isOut)
        {
            actives.Remove(item);

            if (!triggeredIds.Contains(item.Id)) triggeredIds.Add(item.Id);

            setPreId(item.Id);

            if (item.IsSave == 1)
            {
                saveGuide(item);
            }

            if (handleList.Count > 0)
            {
                foreach (HandleGuideListener lis in handleList) lis.handleGuide(item.Id);
            }

            return checkNext(item.Id, eventReceiver, functionName, isOut);
        }
        /// <summary>
        /// �洢ָ������
        /// </summary>
        /// <param name="item"></param>
        void saveGuide(GuideItem item)
        {
            RequestHelper.SendOprationRequest(2, item.OperationId, item.Id);
            //saveGuideHistory(GameCache.playerUserid, item.Id);
        }

        /// <summary>
        /// ����Ƿ�����һ��ָ��
        /// </summary>
        /// <param name="gid"></param>
        void checkNext(int gid)
        {
            List<GuideItem> deletes = new List<GuideItem>();
            foreach (GuideItem item in actives)
            {
                if (item.PreOperationId == gid)
                {
                    //Logger.Log("checkNext:::" + item + " / " + TFUtils.getCurrentTime());
                    GuideNotify notify = findNotify(item.OperationId);
                    if (item.Type < 4)
                    {
                        if (item.IsSave == 1)
                        {
                            saveGuide(item);
                        }
                        updateFunctionState(item.OperationId, item.Type);
                        if (notify != null) notify.SetState(item.Type);
                        deletes.Add(item);
                    }
                    else if (notify != null && (item.Type == 4 || item.Type == 11))
                    {
                        notify.setGuideItem(item);
                    }
                    else if (item.Type > 4 && item.Type != 11)
                    {
                        activeFunctionGuide(null, item);
                    }
                }
            }

            if (deletes.Count > 0)
            {
                foreach (GuideItem item in deletes) actives.Remove(item);
                deletes.Clear();
                deletes = null;
            }
        }

        bool checkNext(int gid, GameObject eventReceiver, string functionName, bool isOut)
        {
            bool findNext = false;
            List<GuideItem> deletes = new List<GuideItem>();
            foreach (GuideItem item in items)
            {
                if (item.PreOperationId == gid)
                {
                    findNext = true;
                    //Logger.Log("checkNext:::" + item + " / " + TFUtils.getCurrentTime());
                    GuideNotify notify = findNotify(item.OperationId);
                    if (item.Type < 4)
                    {
                        if (item.IsSave == 1)
                        {
                            saveGuide(item);
                        }
                        updateFunctionState(item.OperationId, item.Type);
                        if (notify != null) notify.SetState(item.Type);
                        deletes.Add(item);
                    }
                    if (notify != null && (item.Type == 4 || item.Type == 11))
                    {
                            notify.setGuideItem(item);
                     }
                    else if (item.Type > 4 && item.Type != 11)
                    {
                        activeGuideView(item, eventReceiver, functionName, isOut);
                    }
                }
            }

            if (deletes.Count > 0)
            {
                foreach (GuideItem item in deletes) actives.Remove(item);
                deletes.Clear();
                deletes = null;
            }
            return findNext;
        }
        #endregion

        #region find next opration
        //TODO -- del
        public GuideItem findNextOpration(byte state, List<int> expOprationId)
        {
            foreach (GuideItem item in actives)
            {
                if (item.Type == state)
                {
                    bool contain = false;
                    foreach (int id in expOprationId)
                    {
                        if (id == item.OperationId)
                        {
                            contain = true;
                            break;
                        }
                    }
                    if (!contain) return item;
                }
            }
            return null;
        }

        public void removeGuideItem(GuideItem item)
        {
            actives.Remove(item);
        }
        #endregion

        #region guide's history
        /*
        /// <summary>
        /// ��ȡָ����ż�¼
        /// </summary>
        public void loadGuideHistory()
        {
            guideHistory = new Dictionary<int, int>();

            string str = PlayerPrefs.GetString(GameCache.GUIDE_ID, null);
            if (str != null)
            {
                string[] strs = str.Split(new char[]{','});
                foreach (string s in strs)
                {
                    string[] ts = s.Split(new char[] { '=' });
                    if (ts != null)
                    {
                        int uid = int.Parse(ts[0]);
                        int gid = int.Parse(ts[1]);

                        guideHistory.Add(uid, gid);
                    }
                }
            }
        }

        /// <summary>
        /// ������ұ�Ż�ȡ��ǰ��ָ�����
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int getGuideIdByUserId(int userId)
        {
            if (guideHistory == null) loadGuideHistory();

            int gid;
            if (guideHistory.TryGetValue(userId, out gid))
            {
                return gid;
            }
            return 0;
        }

        /// <summary>
        /// ����ָ����ż�¼
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="guideId"></param>
        public void saveGuideHistory(int userId, int guideId)
        {
            if (guideHistory == null) guideHistory = new Dictionary<int, int>();

            if (guideHistory.ContainsKey(userId))
            {
                guideHistory[userId] = guideId;
            }
            else guideHistory.Add(userId, guideId);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (int uid in guideHistory.Keys)
            {
                sb.Append(uid);
                sb.Append('=');
                sb.Append(guideHistory[uid]);
                sb.Append(',');
            }
            sb.Remove(sb.Length - 1, 1);

            PlayerPrefs.SetString(GameCache.GUIDE_ID, sb.ToString());
        }
        */
        #endregion
        #region active guide from outside
        /// <summary>
        /// �ⲿ����ָ��
        /// </summary>
        /// <param name="gid">ָ�����</param>
        /// <param name="eventReceiver">ָ������ʱ�����¼�����</param>
        /// <param name="functionName">ָ������ʱ���õķ�����</param>
        public bool activeGuideFromOutside(int gid, GameObject eventReceiver, string functionName)
        {
            if (items != null && items.Count > 0)
            {
                foreach (GuideItem item in items)
                {
                    if (item.Id == gid)
                    {
                        activeGuideView(item, eventReceiver, functionName, true);
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}