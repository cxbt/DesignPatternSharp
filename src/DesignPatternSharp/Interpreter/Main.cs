using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class Main
    {
        public static void Run()
        {
            try
            {
                StreamReader reader = new StreamReader(File.OpenRead("program.txt"));
                string text;
                while((text = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"text = \"{text}\"");
                    Node node = new ProgramNode();
                    node.parse(new Context(text));
                    Console.WriteLine($"node = {node}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
