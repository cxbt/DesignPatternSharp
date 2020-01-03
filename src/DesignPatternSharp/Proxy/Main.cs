using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Proxy
{
    public class Main
    {
        public static void Run()
        {
            Printable p = new PrinterProxy("Alice");
            Console.WriteLine($"이름은 현재 {p.getPrinterName()}입니다.");
            p.setPrinterName("Bob");
            Console.WriteLine($"이름은 현재 {p.getPrinterName()}입니다.");
            p.print("Hello, world!");
        }
    }
}
