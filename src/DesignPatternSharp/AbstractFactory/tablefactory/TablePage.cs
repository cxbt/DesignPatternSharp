using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory.tablefactory
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {

        }

        public override string makeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{title}</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append($"<h1>{title}</h1>\n");
            buffer.Append("<table style=\"width: 80%; border: 3\">\n");
            foreach(Item item in content)
            {
                buffer.Append(item.makeHTML());
            }
            buffer.Append("</table>");
            buffer.Append($"<hr><address>{author}</address>");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}
