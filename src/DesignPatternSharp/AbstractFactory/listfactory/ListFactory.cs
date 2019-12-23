using DesignPatternSharp.AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.AbstractFactory.listfactory
{
    public class ListFactory : factory.Factory
    {
        public override Link createLink(string caption, string url)
        {
            return new ListLink(caption, url);
        }

        public override Tray createTray(string caption)
        {
            return new ListTray(caption);
        }

        public override Page createPage(string title, string author)
        {
            return new ListPage(title, author);
        }

        
    }
}
