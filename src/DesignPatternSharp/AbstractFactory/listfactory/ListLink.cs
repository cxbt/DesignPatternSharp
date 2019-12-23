using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory.listfactory
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {

        }

        public override string makeHTML()
        {
            return $"    <li><a href=\"{url}\">{caption}</a></li>";
        }
    }
}
