using LibrarySystem;

Book book1 = new Book();
book1.Author = "Napoleon Hill";
book1.Title = "Think and grow rich";
book1.Year = 1937;

Book book2 = new Book { Title = "Goals", Author = "Brian Tracy", Year = 2010 };
Book book3 = new Book { Title = "The psychology of money", Author = "Morgan Housel", Year = 2020  };

Book[] books = new Book[] { book1, book2, book3 }; 

Lybrary lybrary = new Lybrary();
lybrary.AddBooks(books);

//lybrary[1] = book3;
lybrary.RemoveBook(1);
Console.WriteLine(lybrary.FindBook("Goals"));
Console.WriteLine($"{lybrary[1].Title} {lybrary[1].Year}");
Console.WriteLine(lybrary.count);
