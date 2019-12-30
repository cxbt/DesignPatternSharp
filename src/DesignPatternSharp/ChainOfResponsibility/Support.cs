using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.ChainOfResponsibility
{
    public abstract class Support
    {
        private string name;
        private Support next;
        
        public Support(string name)
        {
            this.name = name;
        }

        public Support setNext(Support next)
        {
            this.next = next;
            return next;
        }

        public void support(Trouble trouble)
        {
            if (resolve(trouble))
            {
                done(trouble);
            }
            else if (next != null)
            {
                next.support(trouble);
            }
            else
            {
                fail(trouble);
            }
        }

        protected abstract bool resolve(Trouble trouble);
        protected void done(Trouble trouble)
        {
            Console.WriteLine($"{trouble} is resolved by {this}.");
        }
        protected void fail(Trouble trouble)
        {
            Console.WriteLine($"{trouble} cannot be resolved");
        }

        public override string ToString()
        {
            return name;
        }
    }
}
