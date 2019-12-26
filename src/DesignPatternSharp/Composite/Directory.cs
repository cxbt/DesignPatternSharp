using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Composite
{
    public class Directory : Entry
    {
        private string name;
        private List<Entry> directory = new List<Entry>();

        public Directory(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public override int getSize()
        {
            int size = 0;
            foreach (Entry e in directory)
            {
                size += e.getSize();
            }
            return size;
        }

        public new Entry add(Entry entry)
        {
            directory.Add(entry);
            return this;
        }

        public override void printList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");
            foreach (Entry e in directory)
            {
                e.printList($"{prefix}/{name}");
            }
        }
    }
}
