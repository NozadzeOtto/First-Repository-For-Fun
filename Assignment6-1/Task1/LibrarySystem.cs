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
        private Book[] lybrary;
        
        // Adds Book element to lybrary
        public void AddBooks(Book[] book) 
        {
            lybrary = book;
        }

        // replaces with new empty element
        public void RemoveBook(int index)
        {
            lybrary[index] = new Book();
            //for (int i = index; i < books.Length; i++)
            //{
            //    if (i == books.Length - 1) { books[i] = new Book(); return; }
            //    books[i] = books[++i];
            //}
        }

        // finds with title
        public int FindBook(string title)
        {
            for (int i = 0; i < lybrary.Length; i++)
            {
                if (title == lybrary[i].Title) return i;
            }
            return -1;
        }

        // indexer
        public Book this[int i]
        {
            get { return lybrary[i]; }
            set { lybrary[i] = value; }
        }

        // counts length
        public int count
        {
            get { return lybrary.Length;}
        }

    }
}
