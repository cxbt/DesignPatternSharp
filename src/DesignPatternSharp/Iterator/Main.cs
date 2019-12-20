using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Iterator
{
    public class Main
    {
        public static void Run()
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.append(new Book("이재빈의 나혼자산다 1편"));
            bookShelf.append(new Book("나는 어떻게 잘생겨졌는가"));
            bookShelf.append(new Book("이재빈의 돌파구는 스스로 만든다"));
            bookShelf.append(new Book("이재빈의 요남자 레시피 20선"));

            Iterator it = bookShelf.iterator();
            while(it.hasNext())
            {
                Book book = it.next() as Book;
                Console.WriteLine(book.getName());
            }
        }
    }
}
