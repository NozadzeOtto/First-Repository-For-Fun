using Task2;

internal class Program
{
    public class Person
    {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    }


    public class Organization
    {
        public string Name { get; set; }
        public DateOnly FoundedDate { get; set; }
    }

    CustomList<Person> personList = new CustomList<Person>();
    
}
