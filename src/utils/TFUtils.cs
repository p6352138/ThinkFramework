using System.Collections;

public class TFUtils
{
    public static long getCurrentTime()
    {
        long t = System.DateTime.Now.ToBinary();
        t &= 0xffffffff;
        t /= 10000;
        return t;
    }
}

