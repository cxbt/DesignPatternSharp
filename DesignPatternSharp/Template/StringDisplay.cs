using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Template
{
    class StringDisplay : AbstractDisplay
    {
        private string text;
        private int width;

        public StringDisplay(string text)
        {
            this.text = text;
            this.width = text.Length;
        }

        public override void open()
        {
            printLine();
        }

        public override void print()
        {

            Console.WriteLine("|" + text + "|");
        }

        public override void close()
        {
            printLine();
        }

        private void printLine()
        {
            Console.Write("+");
            for(int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
