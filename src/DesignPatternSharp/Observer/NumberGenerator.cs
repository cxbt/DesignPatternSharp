using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Observer
{
    public abstract class NumberGenerator
    {
        private List<Observer> observers = new List<Observer>();

        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void deleteObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.update(this);
            }
        }

        public abstract int getNumber();
        public abstract void execute();
    }
}
