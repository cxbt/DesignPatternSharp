using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Strategy
{
    public class Player
    {
        private string name;
        private Strategy strategy;
        private int wincount;
        private int losecount;
        private int gamecount;

        public Player(string name, Strategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public Hand nextHand()
        {
            return strategy.nextHand();
        }

        public void win()
        {
            strategy.study(true);
            wincount++;
            gamecount++;
        }

        public void lose()
        {
            strategy.study(false);
            losecount++;
            gamecount++;
        }

        public void even()
        {
            gamecount++;
        }

        public string toString()
        {
            return $"[{name}:{gamecount} games, {wincount} win, {losecount} lose]";
        }
    }
}
