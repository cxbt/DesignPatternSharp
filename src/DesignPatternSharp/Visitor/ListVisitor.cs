using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Visitor
{
    public class ListVisitor : Visitor
    {
        private string currentdir = "";

        public override void visit(File file)
        {
            Console.WriteLine($"{currentdir}/{file}");
        }

        public override void visit(Directory directory)
        {
            Console.WriteLine($"{currentdir}/{directory}");
            string savedir = currentdir;
            currentdir = $"{currentdir}/{directory.getName()}";
            foreach(Entry e in directory.iterator())
            {
                e.accept(this);
            }
            currentdir = savedir;
        }
    }
}
