using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Memento.game
{
    public class Memento
    {
        internal int money;
        internal List<string> fruits;

        internal Memento(int money)
        {
            this.money = money;
            this.fruits = new List<string>();
        }

        public int getMoney()
        {
            return money;
        }

        internal void addFruit(string fruit)
        {
            fruits.Add(fruit);
        }

        internal List<string> getfruits()
        {
            return fruits;
        }
    }
}
