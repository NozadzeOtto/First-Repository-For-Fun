namespace LibrarySystem
{
    public class Book
    {
        public string _title;
        public string _author;
        public int _year;

        public string Title { get => _title; set=> _title = value; }
        public int Year { get => _year; set => _year = value; }
        public string Author { get => _author; set => _author = value; }       
    }

    public class Lybrary
    {
        private Book[] books;
        
        public void AddBooks(Book[] book) 
        {
            books = book;
        }

        //removes element and replaces with next
        public void RemoveBook(int index)
        {
            //books[index] = null;
            for (int i = index; i < books.Length; i++)
            { 
                if (i == books.Length - 1) { books[i] = null; return; }
                books[i] = books[++i];
            }
        }

        public int FindBook(string title)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (title == books[i].Title) return i;
            }
            return -1;
        }

        public Book this[int i]
        {
            get { return books[i]; }
            set { books[i] = value; }
        }

        public int count
        {
            get { return books.Length;}
        }

    }
}
