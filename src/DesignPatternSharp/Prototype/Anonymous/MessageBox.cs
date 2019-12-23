using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.Prototype.framework;

namespace DesignPatternSharp.Prototype.Anonymous
{
    public class MessageBox : Product
    {
        private char decochar;

        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public object Clone()
        {
            return new MessageBox(decochar);
        }

        public void use(string s)
        {
            for (int i = 0; i < s.Length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine();
            Console.WriteLine(decochar + " " + s + " " + decochar);
            for (int i = 0; i < s.Length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine();
        }

        public Product createClone()
        {
            return Clone() as Product;
        }
    }
}
