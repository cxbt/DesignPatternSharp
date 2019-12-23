using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory.tablefactory
{
    public class TableFactory : factory.Factory
    {
        public override Link createLink(string caption, string url)
        {
            return new TableLink(caption, url);
        }

        public override Tray createTray(string caption)
        {
            return new TableTray(caption);
        }

        public override Page createPage(string title, string author)
        {
            return new TablePage(title, author);
        }
    }
}
