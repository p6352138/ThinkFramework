using UnityEngine;
using System.Collections;
using com.think.io;
using com.think.messages;
using Thrift.Protocol;

public class RequestHelper {
    public static void GetCDTimeRequest(out RequestWrapper rw, byte type, int id)
    {
        CDTimeRequest req = new CDTimeRequest();
        req.Type = type;
        req.Id = id;

        rw = new RequestWrapper();
        rw.requestType = 28;
        rw.request = req;
    }
    /// <summary>
    /// 发送指引请求
    /// </summary>
    /// <param name="type"></param>
    /// <param name="opId"></param>
    /// <param name="key"></param>
    public static void SendOprationRequest(byte type, int opId, int key)
    {
        OprationRequest req = new OprationRequest();
        req.Type = type;
        req.Opration_id = opId;
        req.Id = key;

        RequestWrapper rw = new RequestWrapper();
        rw.requestType = 48;
        rw.request = req;

        QueueCache.instance.sendRequest(rw);
    }
}

