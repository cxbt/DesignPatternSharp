using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory.listfactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {

        }

        public override string makeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<li>\n");
            buffer.Append($"{caption}\n");
            buffer.Append("<ul>\n");
            foreach (Item item in tray)
            {
                buffer.Append(item.makeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append("</li>\n");
            return buffer.ToString();
        }
    }
}
