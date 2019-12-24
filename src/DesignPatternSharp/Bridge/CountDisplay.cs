using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Bridge
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl)
        {

        }

        public void multiDisplay(int times)
        {
            open();
            for (int i = 0; i < times; i++)
            {
                print();
            }
            close();
        }
    }
}
