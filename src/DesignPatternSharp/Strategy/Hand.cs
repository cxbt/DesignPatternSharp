using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Strategy
{
    public class Hand
    {
        public const int HANDVALUE_ROCK = 0;
        public const int HANDVALUE_SISS = 1;
        public const int HANDVALUE_PAPE = 2;
        public static Hand[] hand =
        {
            new Hand(HANDVALUE_ROCK),
            new Hand(HANDVALUE_SISS),
            new Hand(HANDVALUE_PAPE)
        };

        private static string[] name =
        {
            "가위",
            "바위",
            "보"
        };

        private int handvalue;

        public Hand(int handvalue)
        {
            this.handvalue = handvalue;
        }

        public static Hand getHand(int handvalue)
        {
            return hand[handvalue];
        }

        public bool isStrongerThan(Hand h)
        {
            return fight(h) == 1;
        }

        public bool isWeakerThan(Hand h)
        {
            return fight(h) == -1;
        }

        private int fight(Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if((this.handvalue + 1) % 3 == h.handvalue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public string toString()
        {
            return name[handvalue];
        }
    }
}
