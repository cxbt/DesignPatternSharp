using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Observer
{
    public class Main
    {
        public static void Run()
        {
            NumberGenerator generator = new RandomNumberGenerator();
            Observer observer1 = new DigitObserver();
            Observer observer2 = new GraphObserver();
            generator.addObserver(observer1);
            generator.addObserver(observer2);
            generator.execute();
        }
    }
}
