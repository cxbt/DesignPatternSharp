using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternSharp.Facade.pagemaker
{
    public class HtmlWriter
    {
        private StreamWriter writer;

        public HtmlWriter(StreamWriter writer)
        {
            this.writer = writer;
        }

        public void title(string title)
        {
            writer.Write("<html>");
            writer.Write("<head>");
            writer.Write($"<title>{title}</title>");
            writer.Write("</head>");
            writer.WriteLine("<body>");
            writer.Write($"<h1>{title}</h1>");
        }

        public void paragraph(string msg)
        {
            writer.WriteLine($"<p>{msg}</p>");
        }

        public void link(string href, string caption)
        {
            paragraph($"<a href=\"{href}\">{caption}</a>");
        }

        public void mailto(string mailaddr, string username)
        {
            link($"mailto: {mailaddr}", username);
        }

        public void close()
        {
            writer.Write("</body>");
            writer.WriteLine("</html>");
            writer.Close();
        }
    }
}
