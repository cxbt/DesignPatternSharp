using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using DesignPatternSharp.Memento.game;

namespace DesignPatternSharp.Memento
{
    public class Main
    {
        public static void Run()
        {
            Gamer gamer = new Gamer(100);
            game.Memento memento = gamer.createMemento();
            for (int i = 0; i < 10 - 0; i++)
            {
                Console.WriteLine($"==={i + 1}");
                Console.WriteLine($"현상:{gamer}");

                gamer.bet();

                Console.WriteLine($"소지금은 {gamer.getMoney()}원이 되었습니다.");

                if (gamer.getMoney() > memento.getMoney())
                {
                    Console.WriteLine("(많이 증가했으므로 현재의 상태를 저장하자)");
                    memento = gamer.createMemento();
                }
                else if (gamer.getMoney() < memento.getMoney() / 2)
                {
                    Console.WriteLine(" (많이 감소했으므로 이전의 상태로 복원하자)");
                    gamer.restoreMemento(memento);
                }

                try
                {
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException)
                {

                }
                Console.WriteLine("");
            }
        }
    }
}
