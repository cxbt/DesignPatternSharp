using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Memento.game
{
    public class Gamer
    {
        private int money;
        private List<string> fruits = new List<string>();
        private Random random = new Random();
        private static string[] fruitsname = { "사과", "포도", "바나나", "귤" };

        public Gamer(int money)
        {
            this.money = money;
        }

        public int getMoney()
        {
            return money;
        }

        public void bet()
        {
            int dice = random.Next(1, 7);
            if (dice == 1)
            {
                money += 100;
                Console.WriteLine("소지금이 증가했습니다.");
            }
            else if (dice == 2)
            {
                money /= 2;
                Console.WriteLine("소지금이 절반이 되었습니다.");
            }
            else if (dice == 6)
            {
                string f = getFruit();
                Console.WriteLine($"과일({f}) 을 받았습니다.");
                fruits.Add(f);
            }
            else
            {
                Console.WriteLine("변한 것이 없습니다.");
            }
        }

        public Memento createMemento()
        {
            Memento m = new Memento(money);
            foreach (string f in fruits)
            {
                if (f.StartsWith("맛있는 "))
                {
                    m.addFruit(f);
                }
            }
            return m;
        }

        public void restoreMemento(Memento memento)
        {
            this.money = memento.money;
            this.fruits = memento.getfruits();
        }

        public override string ToString()
        {
            return $"[money = {money}, fruits = {string.Join(',', fruits)}]";
        }

        public string getFruit()
        {
            string prefix = "";
            if (random.Next(0, 1) != 0)
            {
                prefix = "맛있는";
            }
            return prefix + fruitsname[random.Next(0, fruitsname.Length - 1)];
        }
    }
}
