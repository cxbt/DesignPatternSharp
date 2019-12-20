using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Adapter
{
    public class Banner
    {
        private string text;
        public Banner(string text) => this.text = text;

        public void showWithParen() => Console.WriteLine("(" + text + ")");

        public void showWithAster() => Console.WriteLine("*" + text + "*");
    }
}
