using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Template
{
    public abstract class AbstractDisplay
    {
        public void display()
        {
            open();
            for (int i = 0; i < 5; i++)
            {
                print();
            }
            close();
        }

        public abstract void open();
        public abstract void print();
        public abstract void close();
    }
}
