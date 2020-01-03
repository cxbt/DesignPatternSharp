using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Proxy
{
    public interface Printable
    {
        public abstract void setPrinterName(string name);
        public abstract string getPrinterName();
        public abstract void print(string text);
    }
}
