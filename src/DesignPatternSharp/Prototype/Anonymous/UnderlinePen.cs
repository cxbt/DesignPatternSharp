using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.Prototype.framework;

namespace DesignPatternSharp.Prototype.Anonymous
{
    public class UnderlinePen : Product
    {
        private char ulchar;

        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        public object Clone()
        {
            return new UnderlinePen(ulchar);
        }

        public void use(string s)
        {
            Console.WriteLine("\"" + s + "\"");
            Console.Write(" ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine(" ");
        }

        public Product createClone()
        {
            return Clone() as Product;
        }
    }
}
