using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Strategy
{
    public class WinningStrategy : Strategy
    {
        private Random random;
        private bool won = false;
        private Hand prevHand;

        public WinningStrategy(int seed)
        {
            random = new Random(seed);
        }

        public Hand nextHand()
        {
            if (!won)
            {
                prevHand = Hand.getHand(random.Next(2));
            }
            return prevHand;
        }

        public void study(bool win)
        {
            won = win;
        }
    }
}
