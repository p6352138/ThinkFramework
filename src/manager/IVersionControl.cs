using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.think.manager
{
    public interface IVersionControl
    {
        string loadText(string name);
    }
}
