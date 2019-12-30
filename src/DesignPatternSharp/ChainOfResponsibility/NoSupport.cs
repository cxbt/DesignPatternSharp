using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.ChainOfResponsibility
{
    public class NoSupport : Support
    {
        public NoSupport(string name) : base(name)
        {

        }

        protected override bool resolve(Trouble trouble)
        {
            return false;
        }
    }
}
