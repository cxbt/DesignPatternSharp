using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.FlyWeight
{
    public class BigString
    {
        private BigChar[] bigchars;

        public BigString(string text)
        {
            bigchars = new BigChar[text.Length];
            BigCharFactory factory = BigCharFactory.getInstance();
            for (int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i] = factory.getBigChar(text[i]);
            }
        }

        public void print()
        {
            for (int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i].print();
            }
        }
    }
}
