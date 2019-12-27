using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Decorator
{
    public abstract class Border : Display
    {
        protected Display display;

        protected Border(Display display)
        {
            this.display = display;
        }
    }
}
