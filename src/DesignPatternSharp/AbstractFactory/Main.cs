using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternSharp.AbstractFactory.factory;

namespace DesignPatternSharp.AbstractFactory
{
    public class Main
    {
        public static void Run(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: DesignPatternSharp.exe assembly.");
                Console.WriteLine("Example 1: DesignPatternSharp.exe DesignPatternSharp.AbstractFactory.listfactory.ListFactory");
                Console.WriteLine("Example 2: DesignPatternSharp.exe DesignPatternSharp.AbstractFactory.tablefactory.TableFactory");
                return;
            }
            factory.Factory factory = AbstractFactory.factory.Factory.getFactory(args[0]);

            Link joins = factory.createLink("중앙일보", "http://www.joins.com/");
            Link chosun = factory.createLink("조선일보", "http://www.chosun.com/");

            Link opgg = factory.createLink("OP.GG", "http://op.gg/");
            Link fowkr = factory.createLink("Fow.kr", "http://fow.kr/");
            Link google = factory.createLink("Google", "http://www.google.com/");
            Link naver = factory.createLink("네이버", "http://www.naver.com/");

            Tray traynews = factory.createTray("신문");
            traynews.add(joins);
            traynews.add(chosun);

            Tray traylol = factory.createTray("LOL");
            traylol.add(opgg);
            traylol.add(fowkr);

            Tray traysearch = factory.createTray("검색엔진");
            traysearch.add(google);
            traysearch.add(naver);

            Page page = factory.createPage("LinkPage", "뫄뫄닷컴");
            page.add(traynews);
            page.add(traysearch);
            page.output();
        }
    }
}
