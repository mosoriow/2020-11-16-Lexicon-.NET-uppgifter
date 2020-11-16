using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Library : IEnumerable<Book>
    {
        List<Book> books;
        int numberOfBooks;

        public Library()
        {
            this.books = new List<Book>();
            this.numberOfBooks = 0;
        }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.numberOfBooks = this.books.Count;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books) ;
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IENumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
            }

        }

    }
}
