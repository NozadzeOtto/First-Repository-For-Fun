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
            //lybrary[index] = default(Book);
            for (int i = index; i < lybrary.Length-1; i++)
            {   
                lybrary[i] = lybrary[++i];
            }
            lybrary[lybrary.Length-1] = default(Book);
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
            get 
            {
                if (i < 0 || i >= lybrary.Length) throw new IndexOutOfRangeException();
                return lybrary[i]; 
            }
            set 
            {
                if (i < 0 || i >= lybrary.Length) throw new IndexOutOfRangeException();
                lybrary[i] = value; 
            }
        }

        // counts length
        public int count
        {
            get 
            { 
                int count = 0; 
                for (int i = 0;i < lybrary.Length; i++)
                {
                    // not include empty Book()'s
                    if ( !(string.IsNullOrEmpty(lybrary[i].Title) && string.IsNullOrEmpty(lybrary[i].Author) && lybrary[i].Year ==0)) count++;
                }
                return count;
            }

        }

    }
}
