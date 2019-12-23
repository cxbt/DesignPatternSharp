using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Singleton
{
    public class Main
    {
        public static void Run()
        {
            Console.WriteLine("시작.");
            Singleton obj1 = Singleton.getInstance();
            Singleton obj2 = Singleton.getInstance();
            if (obj1 == obj2)
            {
                Console.WriteLine("obj1과 obj2는 같은 인스턴스입니다.");
            }
            else
            {
                Console.WriteLine("obj1과 obj2는 다른 인스턴스입니다.");
            }
            Console.WriteLine("종료.");
        }
    }
}
