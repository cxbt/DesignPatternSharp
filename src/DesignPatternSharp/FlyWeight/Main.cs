using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.FlyWeight
{
    public class Main
    {
        public static void Run(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: DesignPatternSharp.exe <digits>");
                Console.WriteLine("Example: DesignPatternSharp.exe 1212132");
                return;
            }
            BigString bs = new BigString(args[0]);
            bs.print();
        }
    }
}
