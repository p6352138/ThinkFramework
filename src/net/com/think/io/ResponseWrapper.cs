using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift.Protocol;
using Thrift.Transport;

namespace com.think.io
{
    public class ResponseWrapper
    {
        public byte responseType;
        public TBase response;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(" responseType:" + responseType + " ");
            sb.Append(response);
            return sb.ToString();
        }
    }
}
