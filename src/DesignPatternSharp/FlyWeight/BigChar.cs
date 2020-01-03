using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DesignPatternSharp.FlyWeight
{
    public class BigChar
    {
        private char charname;
        private string fontdata;

        public BigChar(char charname)
        {
            this.charname = charname;
            try
            {
                this.fontdata = File.ReadAllText($"big{charname}.txt");
            }
            catch (IOException)
            {
                this.fontdata = $"{charname}?";
            }
        }

        public void print()
        {
            Console.Write(fontdata);
        }
    }
}
