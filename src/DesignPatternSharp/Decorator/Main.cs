using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Decorator
{
    public class Main
    {
        public static void Run()
        {
            Display b1 = new StringDisplay("Hello, world!");
            Display b2 = new SideBorder(b1, '#');
            Display b3 = new FullBorder(b2);
            b1.show();
            b2.show();
            b3.show();
            Display b4 = new SideBorder(
                new FullBorder(
                    new FullBorder(
                        new SideBorder(
                            new FullBorder(
                                new StringDisplay("안녕하세욤")
                                )
                            , '*')
                        )
                    )
                , '*');
            b4.show();
        }
    }
}
