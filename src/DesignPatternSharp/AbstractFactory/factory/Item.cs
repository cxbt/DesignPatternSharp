using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.AbstractFactory.factory
{
    public abstract class Item
    {
        protected string caption;

        public Item(string caption)
        {
            this.caption = caption;
        }

        public abstract string makeHTML();
    }
}
