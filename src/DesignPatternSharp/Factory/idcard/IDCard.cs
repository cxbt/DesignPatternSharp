using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.Factory.framework;

namespace DesignPatternSharp.Factory.idcard
{
    public class IDCard : Product
    {
        private string owner;
        
        public IDCard(string owner)
        {
            Console.WriteLine($"{owner}의 카드를 만듭니다.");
            this.owner = owner;
        }

        public override void use()
        {
            Console.WriteLine($"{owner}의 카드를 사용합니다.");
        }

        public string getOwner()
        {
            return owner;
        }
    }
}
