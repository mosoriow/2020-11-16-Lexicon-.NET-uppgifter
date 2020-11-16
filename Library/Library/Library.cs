using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Library
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
    }
}
