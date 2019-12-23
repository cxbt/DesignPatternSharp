using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Prototype.framework
{
    public interface Product : ICloneable
    {
        public abstract void use(string s);
        public abstract Product createClone();
    }
}
