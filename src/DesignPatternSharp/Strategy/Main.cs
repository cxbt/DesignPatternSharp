using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Strategy
{
    public class Main
    {
        public static void Run(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: DesignPatternSharp.exe <randomseed1> <randomseed2>");
                Console.WriteLine("Example: DesignPatternSharp.exe 314 15");
                return;
            }
            int seed1 = Int32.Parse(args[0]);
            int seed2 = Int32.Parse(args[1]);
            Player player1 = new Player("두리", new WinningStrategy(seed1));
            Player player2 = new Player("하나", new ProbStrategy(seed2));
            for (int i = 0; i <10000;i++)
            {
                Hand nexthand1 = player1.nextHand();
                Hand nexthand2 = player2.nextHand();
                if (nexthand1.isStrongerThan(nexthand2))
                {
                    Console.WriteLine($"Winner: {player1.toString()}");
                    player1.win();
                    player2.lose();
                }
                else if (nexthand2.isStrongerThan(nexthand1))
                {
                    Console.WriteLine($"Winner: {player2.toString()}");
                    player1.lose();
                    player2.win();
                }
                else
                {
                    Console.WriteLine($"Even...");
                    player1.even();
                    player2.even();
                }
            }
            Console.WriteLine("Total Result:");
            Console.WriteLine(player1.toString());
            Console.WriteLine(player2.toString());
        }
    }
}
