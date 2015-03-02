using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift.Protocol;
using Thrift.Transport;

namespace com.think.io
{
    public class RequestWrapper
    {
        public byte requestType;
        public TBase request;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(" requestType:" + requestType + " ");
            sb.Append(request);
            return sb.ToString();
        }
    }
}
