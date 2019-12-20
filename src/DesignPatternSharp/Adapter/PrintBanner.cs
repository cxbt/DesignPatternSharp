using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Adapter
{
    public class PrintBanner : Banner, Print
    {
        public PrintBanner(string text) : base(text)
        {
            
        }

        void Print.printStrong()
        {
            showWithParen();
        }

        void Print.printWeak()
        {
            showWithAster();
        }
    }
}
