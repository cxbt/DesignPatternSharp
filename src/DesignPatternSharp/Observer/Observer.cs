using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Observer
{
    public interface Observer
    {
        public abstract void update(NumberGenerator generator);
    }
}
