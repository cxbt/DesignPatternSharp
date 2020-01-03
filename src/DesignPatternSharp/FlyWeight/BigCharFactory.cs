using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.FlyWeight
{
    public class BigCharFactory
    {
        private Dictionary<string, BigChar> pool = new Dictionary<string, BigChar>();
        private static BigCharFactory singleton = new BigCharFactory();
        
        private BigCharFactory()
        {

        }

        public static BigCharFactory getInstance()
        {
            return singleton;
        }

        public BigChar getBigChar(char charname)
        {
            BigChar bc;
            if (pool.TryGetValue($"{charname}", out bc) == false)
            {
                bc = new BigChar(charname);
                pool.Add($"{charname}", bc);
            }
            return bc;
        }
    }
}
