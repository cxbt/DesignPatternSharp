using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.AbstractFactory.factory
{
    public abstract class Tray : Item
    {
        protected List<Item> tray = new List<Item>();

        public Tray(string caption) : base(caption)
        {

        }

        public void add(Item item)
        {
            tray.Add(item);
        }
    }
}
