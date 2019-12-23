using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternSharp.AbstractFactory.factory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();

        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void add(Item item)
        {
            content.Add(item);
        }

        public void output()
        {
            try
            {
                string filename = $"{title}.html";
                FileStream writer = File.OpenWrite(filename);
                writer.Write(ToBytes(this.makeHTML()));
                writer.Close();
                Console.WriteLine($"{filename}을 작성했습니다.");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public abstract string makeHTML();

        private byte[] ToBytes(string value)
        {
            return UTF8Encoding.UTF8.GetBytes(value);
        }
    }
}
