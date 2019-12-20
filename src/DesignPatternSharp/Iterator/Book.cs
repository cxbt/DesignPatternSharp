using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Iterator
{
    public class Book
    {
        private string Name;

        public Book(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }
    }
}
