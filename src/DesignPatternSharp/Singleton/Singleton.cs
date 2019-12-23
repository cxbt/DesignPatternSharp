using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Singleton
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();

        private Singleton()
        {
            Console.WriteLine("인스턴스 생성");
        }

        public static Singleton getInstance()
        {
            return singleton;
        }
    }
}
