using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DesignPatternSharp.Builder
{
    public class HTMLBuilder : Builder
    {
        private string filename;
        private FileStream writer;

        public override void makeTitle(string title)
        {
            filename = title + ".html";
            try
            {
                writer = File.OpenWrite(filename);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            writer.Write(ToBytes($"<html><head><title>{title}</title></head><body>\n"));
            writer.Write(ToBytes($"<h1>{title}</h1>\n"));
        }

        public override void makeString(string str)
        {
            writer.Write(ToBytes($"<p>{str}</p>\n"));
        }

        public override void makeItems(string[] items)
        {
            writer.Write(ToBytes("<ul>\n"));
            for (int i = 0; i < items.Length; i++)
            {
                writer.Write(ToBytes($"<li>{items[i]}</li>\n"));
            }
            writer.Write(ToBytes("</ul>"));
        }

        public override void close()
        {
            writer.Write(ToBytes("</body></html>\n"));
            writer.Close();
        }

        public string getResult()
        {
            return filename;
        }

        private byte[] ToBytes(string value)
        {
            return UTF8Encoding.UTF8.GetBytes(value);
        }
    }
}
