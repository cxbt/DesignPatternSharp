using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Visitor
{
    public abstract class Visitor
    {
        public abstract void visit(File file);
        public abstract void visit(Directory directory);
    }
}
