using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public long BookNumber { get; set; }

        public Book(string title, string author, long bookNumber) 
        { 
            if (title == null || title == "") throw new ArgumentNullException("Title can't be empty.");
            if (author == null || author == "") throw new ArgumentNullException("Author can't be empty.");
            if (bookNumber == 0) throw new ArgumentNullException("Book Number Can't be 0.");

            Title = title;
            Author = author;
            BookNumber = bookNumber;
        
        }

        public Book()
        {

        }
    }
}
