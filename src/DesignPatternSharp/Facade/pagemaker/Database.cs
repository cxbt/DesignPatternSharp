using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternSharp.Facade.pagemaker
{
    public class Database
    {
        private Database()
        {

        }

        public static Dictionary<string, string> getProperties(string dbname)
        {
            string filename = dbname + ".txt";
            Dictionary<string, string> prop = new Dictionary<string, string>();
            try
            {
                foreach(string p in File.ReadAllText(filename).Split('\n'))
                {
                    prop.Add(p.Split("=")[0], p.Split("=")[1]);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Warning: {filename} is not found.");
                Console.WriteLine(e.StackTrace);
            }
            return prop;
        }
    }
}
