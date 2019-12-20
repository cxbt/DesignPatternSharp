using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Iterator
{
    public interface Iterator
    {
        public bool hasNext();
        public object next();
    }
}
