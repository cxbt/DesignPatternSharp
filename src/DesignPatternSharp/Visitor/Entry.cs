using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Visitor
{
    public abstract class Entry : Element
    {
        public abstract string getName();
        public abstract int getSize();

        public Entry add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public IEnumerable<Entry> iterator()
        {
            throw new FileTreatmentException();
        }

        public override string ToString()
        {
            return $"{getName()} ({getSize()})";
        }

        public abstract void accept(Visitor v);
    }
}
