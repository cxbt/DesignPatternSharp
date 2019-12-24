using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;

        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = str.Length;
        }

        public override void rawOpen()
        {
            printLine();
        }

        public override void rawPrint()
        {
            Console.WriteLine($"|{str}|");
        }

        public override void rawClose()
        {
            printLine();
        }

        private void printLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
