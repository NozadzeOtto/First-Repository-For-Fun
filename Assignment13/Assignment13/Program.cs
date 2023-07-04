using Assignment13;

//Book book1 = new("", "", 44);
Book book2 = new("Goals", "Brian Tracy", 4444);
Book book3 = null;

Library library = new Library();
library.Capacity = 2;

try
{
    //library.AddBook(book1);
    library.AddBook(book2);
    //library.AddBook(book3);
}
catch(ApplicationException ex)
{
    Console.WriteLine(ex);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine(library.Capacity);
}
