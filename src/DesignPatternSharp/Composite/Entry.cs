using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Composite
{
    public abstract class Entry
    {
        public abstract string getName();
        public abstract int getSize();

        public Entry add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public void printList()
        {
            printList("");
        }

        public abstract void printList(string prefix);

        public override string ToString()
        {
            return $"{getName()} ({getSize()})";
        }
    }
}
