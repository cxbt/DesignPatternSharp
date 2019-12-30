using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternSharp.Observer
{
    public class GraphObserver : Observer
    {
        public void update(NumberGenerator generator)
        {
            Console.Write("GraphObserver:");
            int count = generator.getNumber();
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            try
            {
                Thread.Sleep(100);
            }
            catch (ThreadInterruptedException)
            {

            }
        }
    }
}
