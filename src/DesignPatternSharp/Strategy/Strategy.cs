using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Strategy
{
    public interface Strategy
    {
        public abstract Hand nextHand();
        public abstract void study(bool win);
    }
}
