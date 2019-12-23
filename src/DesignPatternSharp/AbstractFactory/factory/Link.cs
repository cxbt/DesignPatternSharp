using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.AbstractFactory.factory
{
    public abstract class Link : Item
    {
        protected string url;

        public Link(string caption, string url) : base(caption)
        {
            this.url = url;
        }
    }
}
