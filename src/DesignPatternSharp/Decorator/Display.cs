using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Decorator
{
    public abstract class Display
    {
        public abstract int getColumns();
        public abstract int getRows();
        public abstract string getRowText(int row);
        public void show()
        {
            for (int i = 0; i < getRows(); i++)
            {
                Console.WriteLine(getRowText(i));
            }
        }
    }
}
