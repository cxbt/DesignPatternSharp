using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory.tablefactory
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption)
        {

        }

        public override string makeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<td>");
            buffer.Append("<table style=\"width: 100%; border: 1px\"><tr>");
            buffer.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{tray.Count}\"><b>{caption}</td>");
            buffer.Append("</tr>\n");
            buffer.Append("<tr>");
            foreach (Item item in tray)
            {
                buffer.Append(item.makeHTML());
            }
            buffer.Append("</tr></table>");
            buffer.Append("</td>");
            return buffer.ToString();
        }
    }
}
