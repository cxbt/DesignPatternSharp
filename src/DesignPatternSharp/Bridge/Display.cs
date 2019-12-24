using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Bridge
{
    public class Display
    {
        private DisplayImpl impl;

        public Display(DisplayImpl impl)
        {
            this.impl = impl;
        }

        public void open()
        {
            impl.rawOpen();
        }

        public void print()
        {
            impl.rawPrint();
        }

        public void close()
        {
            impl.rawClose();
        }

        public void display()
        {
            open();
            print();
            close();
        }
    }
}
