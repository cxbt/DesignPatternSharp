using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory.listfactory
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {

        }

        public override string makeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{title}</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append($"<h1>{title}</h1>\n");
            buffer.Append("<ul>\n");
            foreach (Item item in content)
            {
                buffer.Append(item.makeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append($"<hr><address>{author}</address>");
            buffer.Append("</body></html>");
            return buffer.ToString();
        }
    }
}
