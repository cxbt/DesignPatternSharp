using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.Facade.pagemaker;

namespace DesignPatternSharp.Facade
{
    public class Main
    {
        public static void Run()
        {
            PageMaker.makeWelcomePage("youngjin@youngjin.com", "welcome.html");
        }
    }
}
