using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder buffer = new StringBuilder();

        public override void makeTitle(string title)
        {
            buffer.Append("--------------------\n");
            buffer.Append("『" + title + "』\n");
            buffer.Append("\n");
        }
        
        public override void makeString(string str)
        {
            buffer.Append('■' + str + "\n");
            buffer.Append("\n");
        }

        public override void makeItems(string[] items)
        {
            for(int i = 0; i < items.Length; i++)
            {
                buffer.Append("  ▶" + items[i] + "\n");
            }
            buffer.Append("\n");
        }

        public override void close()
        {
            buffer.Append("--------------------\n");
        }

        public string getResult()
        {
            return buffer.ToString();
        }
    }
}
