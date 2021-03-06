﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Composite
{
    public class File : Entry
    {
        private string name;
        private int size;

        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public override string getName()
        {
            return name;
        }

        public override int getSize()
        {
            return size;
        }

        public override void printList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");
        }
    }
}
