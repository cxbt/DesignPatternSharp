using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Builder
{
    public class Main
    {
        public static void Run(string[] args)
        {
            if (args.Length != 1)
            {
                usage();
                return;
            }
            if (args[0].Equals("plain"))
            {
                TextBuilder textbuilder = new TextBuilder();
                Director director = new Director(textbuilder);
                director.construct();
                string result = textbuilder.getResult();
                Console.WriteLine(result);
            }
            else if (args[0].Equals("html"))
            {
                HTMLBuilder htmlbuilder = new HTMLBuilder();
                Director director = new Director(htmlbuilder);
                director.construct();
                string filename = htmlbuilder.getResult();
                Console.WriteLine($"{filename}가 작성되었습니다.");
            }
            else
            {
                usage();
                return;
            }
        }

        public static void usage()
        {
            Console.WriteLine("Usage: DesignPatternSharp.exe plain (일반 텍스트로 문서 작성)");
            Console.WriteLine("Usage: DesignPatternSharp.exe html  (HTML 파일로  문서 작성)");
        }
    }
}
