using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Observer
{
    public class RandomNumberGenerator : NumberGenerator
    {
        private Random random = new Random();
        private int number;

        public override int getNumber()
        {
            return number;
        }

        public override void execute()
        {
            for (int i = 0; i < 20; i++)
            {
                number = random.Next(1, 50);
                notifyObservers();
            }
        }
    }
}
