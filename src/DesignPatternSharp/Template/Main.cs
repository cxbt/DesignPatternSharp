using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Template
{
    public class Main
    {
        public static void Run()
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello World!");
            AbstractDisplay d3 = new StringDisplay("안녕하세욥");

            d1.display();
            d2.display();
            d3.display();
        }
    }
}
