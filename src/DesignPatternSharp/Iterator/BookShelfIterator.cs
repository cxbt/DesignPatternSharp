using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Iterator
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf Shelf;
        private int Index;

        public BookShelfIterator(BookShelf shelf)
        {
            this.Shelf = shelf;
            this.Index = 0;
        }

        public bool hasNext() => Shelf.getLength() > Index;

        public object next() => Shelf.getBookAt(Index++);
    }
}
