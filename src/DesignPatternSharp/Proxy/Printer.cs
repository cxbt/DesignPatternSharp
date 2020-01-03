using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternSharp.Proxy
{
    public class Printer : Printable
    {
        private string name;

        public Printer()
        {
            heavyJob("Printer의 인스턴스를 생성 중");
        }

        public Printer(string name)
        {
            this.name = name;
            heavyJob($"Printer의 인스턴스 ({name}) 을 생성 중");
        }

        public void setPrinterName(string name)
        {
            this.name = name;
        }

        public string getPrinterName()
        {
            return name;
        }

        public void print(string text)
        {
            Console.WriteLine($"=== {name} ===");
            Console.WriteLine(text);
        }

        private void heavyJob(string msg)
        {
            Console.Write(msg);
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Thread.Sleep(1000);
                }
                catch(ThreadInterruptedException)
                {

                }
                Console.Write(".");
            }
            Console.WriteLine("완료.");
        }
    }
}
