using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Visitor
{
    public interface Element
    {
        public abstract void accept(Visitor v);
    }
}
