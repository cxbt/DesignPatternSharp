using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Proxy
{
    public class PrinterProxy : Printable
    {
        private string name;
        private Printer real;

        public PrinterProxy()
        {

        }

        public PrinterProxy(string name)
        {
            this.name = name;
        }

        public void setPrinterName(string name)
        {
            if (real != null)
            {
                real.setPrinterName(name);
            }
            this.name = name;
        }

        public string getPrinterName()
        {
            return name;
        }

        public void print(string text)
        {
            realize();
            real.print(text);
        }

        private void realize()
        {
            if (real == null)
            {
                real = new Printer(name);
            }
        }
    }
}
