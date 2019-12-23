using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Factory.framework
{
    public abstract class Factory
    {
        public Product create(string owner)
        {
            Product p = createProduct(owner);
            registerProduct(p);
            return p;
        }

        public abstract Product createProduct(string owner);
        public abstract void registerProduct(Product product);
    }
}
