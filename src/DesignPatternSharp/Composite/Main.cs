using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Composite
{
    public class Main
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Making root entries...");
                Directory rootdir = new Directory("root");
                Directory bindir = new Directory("bin");
                Directory tmpdir = new Directory("tmp");
                Directory usrdir = new Directory("usr");
                rootdir.add(bindir);
                rootdir.add(tmpdir);
                rootdir.add(usrdir);
                bindir.add(new File("vi", 10000));
                bindir.add(new File("latex", 20000));
                rootdir.printList();

                Console.WriteLine();
                Console.WriteLine("Making user entries...");
                Directory Kim = new Directory("Kim");
                Directory Lee = new Directory("Lee");
                Directory Park = new Directory("Park");
                usrdir.add(Kim);
                usrdir.add(Lee);
                usrdir.add(Park);
                Kim.add(new File("diary.html", 100));
                Kim.add(new File("composite.cs", 200));
                Lee.add(new File("memo.tex", 300));
                Park.add(new File("game.doc", 400));
                Park.add(new File("junk.mail", 500));
                rootdir.printList();
            }
            catch (FileTreatmentException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
