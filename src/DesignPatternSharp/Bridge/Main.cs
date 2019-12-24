using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Bridge
{
    public class Main
    {
        public static void Run()
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Korea."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, world"));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, universe"));

            d1.display();
            d2.display();
            d3.display();
            d3.multiDisplay(5);
        }
    }
}
