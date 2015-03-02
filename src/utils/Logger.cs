using UnityEngine;
using System.Collections;

public class Logger {
 
    static bool mInfo = true;
    public static bool handleInfo { get { return mInfo; } set { mInfo = value; } }
    static bool mLog = true;
    public static bool handleLog { get { return mLog; } set { mLog = value; } }
    static bool mWarning = true;
    public static bool handleWarning { get { return mWarning; } set { mWarning = value; } }
    static bool mError = true;
    public static bool handleError { get { return mError; } set { mError = value; } }
    static bool mException = true;
    public static bool handleException { get { return mException; } set { mException = value; } }

    public static void Info(object msg)
    {
        if (!handleInfo) return;

        Debug.Log(msg);
    }

    public static void Info(object msg, Object context)
    {
        if (!handleInfo) return;

        Debug.Log(msg, context);
    }

    public static void Log(object msg)
    {
        if (!handleLog) return;

        Debug.Log(msg);
    }

    public static void Log(object msg, Object context)
    {
        if (!handleLog) return;

        Debug.Log(msg, context);
    }

    public static void Warning(object msg)
    {
        if (!handleWarning) return;

        Debug.LogWarning(msg);
    }

    public static void Warning(object msg, Object context)
    {
        if (!handleWarning) return;
        
        Debug.LogWarning(msg, context);
    }

    public static void Error(object msg)
    {
        if (!handleError) return;
        
        Debug.LogError(msg);
    }

    public static void Error(object msg, Object context)
    {
        if (!handleError) return;

        Debug.LogError(msg, context);
    }

    public static void Exception(System.Exception exception)
    {
        if (handleException) 
		{
#if UNITY_3_5
			Debug.LogError(exception.Message);
#else
			Debug.LogException(exception);
#endif
		}
    }

    public static void Exception(System.Exception exception, Object context)
    {
        if (handleException) 
		{
#if UNITY_3_5
			Debug.LogError(exception.Message, context);
#else
			Debug.LogException(exception, context);
#endif
		}
    }
}
