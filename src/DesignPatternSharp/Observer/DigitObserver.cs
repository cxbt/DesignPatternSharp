using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternSharp.Observer
{
    public class DigitObserver : Observer
    {
        public void update(NumberGenerator generator)
        {
            Console.WriteLine($"DigitObserver: {generator.getNumber()}");
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
