using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class Library
    {   
        private List<Book> books;
        public long Capacity { get; set; }

        public Library() 
        {
            books = new List<Book>();
            Capacity = 1;
        }

        public void AddBook(Book book)
        {
            if(book == null) throw new ArgumentNullException(nameof(book));
            if (books.Count >= Capacity) throw new ArgumentOutOfRangeException($"Capacity is full: {Capacity}.");
            books.Add(book);
        }

        public Book GetBook (long BookNumber) 
        {
            var myException = new BookNotFoundException($"Book not found with number {BookNumber}");
            Book book = books.Find(x => x.BookNumber == BookNumber);
            if (book == null) throw myException;
            return book;      
        }
    }
}
