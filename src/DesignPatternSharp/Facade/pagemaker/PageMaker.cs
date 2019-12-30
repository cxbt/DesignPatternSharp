using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternSharp.Facade.pagemaker
{
    public class PageMaker
    {
        private PageMaker()
        {

        }

        public static void makeWelcomePage(string mailaddr, string filename)
        {
            try
            {
                Dictionary<string, string> mailprop = Database.getProperties("maildata");
                string username = mailprop[mailaddr];
                HtmlWriter writer = new HtmlWriter(new StreamWriter(filename));
                writer.title($"Welcome to {username}'s page!");
                writer.paragraph($"{username}의 페이지에 오신 걸 환영합니다!");
                writer.paragraph("메일을 기다리고 있습니다");
                writer.mailto(mailaddr, username);
                writer.close();
                Console.WriteLine($"{filename} is created for {mailaddr} ({username})");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
