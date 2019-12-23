using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Prototype.framework
{
    public class Manager
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();
        
        public void register(string name, Product proto)
        {
            showcase.Add(name, proto);
        }

        public Product create(string protoname)
        {
            Product p = showcase[protoname] as Product;
            return p.createClone();
        }
    }
}
