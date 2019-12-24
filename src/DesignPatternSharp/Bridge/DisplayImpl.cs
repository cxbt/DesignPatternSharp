using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Bridge
{
    public abstract class DisplayImpl
    {
        public abstract void rawOpen();
        public abstract void rawPrint();
        public abstract void rawClose();
    }
}
