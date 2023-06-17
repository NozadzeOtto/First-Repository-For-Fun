using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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

    public static void Main(string[] args)
    {
        CustomList<Person> personList = new CustomList<Person>();
        Person person1 = new Person { FirstName = "Otto", LastName = "Nozadze", Age = 20 };
        Person person2 = new Person { FirstName = "Otto2", LastName = "Nozadze2", Age = 22 };
        Person person3 = new Person { FirstName = "Otto3", LastName = "Nozadze3", Age = 23 };
        // AddElement
        personList.AddElement(person1);
        personList.AddElement(person2);
        personList.AddElement(person3);
        // Count
        Console.WriteLine(personList.Count); // 3
        // RemoveEllement
        personList.RemoveElement(person1);
        Console.WriteLine(personList.Count); // 2


        // AddList 
        CustomList<Person> personList2 = new CustomList<Person>();
        personList2.AddElement(person1);
        personList2.AddElement(person2);
        personList.AddList(personList2);
        Console.WriteLine(personList.Count); // 4

        // GetList
        CustomList<Person> getList;
        Console.WriteLine( personList.GetList(-1,2,out getList));
    }
    
    
}
