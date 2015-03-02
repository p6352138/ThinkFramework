using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.think.io
{
    public class Util
    {
        private Util()
        { }

        public static byte[] int2ByteArray(int i)
        {
            byte[] array = new byte[4];
            array[3] = (byte)i;
            array[2] = (byte) (i >> 8);
            array[1] = (byte)(i >> 16);
            array[0] = (byte)(i >> 24);
            return array;
        }

        public static byte[] short2ByteArray(short i)
        {
            byte[] array = new byte[2];
            array[1] = (byte)i;
            array[0] = (byte)(i >> 8);
            
            return array;
        }

        public static short byteArray2Short(byte[] i16rd)
        {
            short size = (short) (((i16rd[0] & 0xff) << 8) |((i16rd[1] & 0xff)));
            return size;
        }

        public static short byteArray2Short(sbyte[] i16rd)
        {
            short size = (short)(((i16rd[0] & 0xff) << 8) | ((i16rd[1] & 0xff)));
            return size;
        }

        public static int byteArray2Int(byte[] i32rd)
        {
            int size =
                ((i32rd[0] & 0xff) << 24) |
                ((i32rd[1] & 0xff) << 16) |
                ((i32rd[2] & 0xff) << 8) |
                ((i32rd[3] & 0xff));
            return size;
        }
    }
}