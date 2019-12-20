using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Adapter
{
    public class Main
    {
        public static void Run()
        {
            Print p = new PrintBanner("Hellow");
            p.printWeak();
            p.printStrong();
        }
    }
}
