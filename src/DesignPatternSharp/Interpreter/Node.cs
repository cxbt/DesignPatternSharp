using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public abstract class Node
    {
        public abstract void parse(Context context);
    }
}
