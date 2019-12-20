using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Iterator
{
    public class BookShelf : Aggregate
    {
        private List<Book> Shelf;

        public BookShelf(int length)
        {
            Shelf = new List<Book>(length);
        }

        public void append(Book book)
        {
            Shelf.Add(book);
        }

        public Book getBookAt(int index)
        {
            return Shelf[index];
        }

        public int getLength()
        {
            return Shelf.Count;
        }

        public override Iterator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
