using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Adapter
{
    public interface Print
    {
        public abstract void printWeak();
        public abstract void printStrong();
    }
}
