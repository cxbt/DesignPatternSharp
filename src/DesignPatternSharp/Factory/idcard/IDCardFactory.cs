using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.Factory.framework;

namespace DesignPatternSharp.Factory.idcard
{
    public class IDCardFactory : framework.Factory
    {
        private List<string> owners = new List<string>();

        public override Product createProduct(string owner)
        {
            return new IDCard(owner);
        }

        public override void registerProduct(Product product)
        {
            owners.Add((product as IDCard).getOwner());
        }

        public List<string> getOwners()
        {
            return owners;
        }
    }
}
