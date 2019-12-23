using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.Factory.framework;
using DesignPatternSharp.Factory.idcard;


namespace DesignPatternSharp.Factory
{
    public class Main
    {
        public static void Run()
        {
            framework.Factory factory = new IDCardFactory();
            Product card1 = factory.create("홍길동");
            Product card2 = factory.create("이순신");
            Product card3 = factory.create("강감찬");
            card1.use();
            card2.use();
            card3.use();
        }
    }
}
