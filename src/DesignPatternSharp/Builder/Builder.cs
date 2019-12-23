using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Builder
{
    public abstract class Builder
    {
        public abstract void makeTitle(string title);
        public abstract void makeString(string str);
        public abstract void makeItems(string[] items);
        public abstract void close();
    }
}
