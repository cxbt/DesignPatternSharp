using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory.tablefactory
{
    public class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url)
        {

        }

        public override string makeHTML()
        {
            return $"<td><a href=\"{url}\">{caption}</a></td>\n";
        }
    }
}
