using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;
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
        Person person1 = new Person { FirstName = "Otto1", LastName = "Nozadze1", Age = 21 };
        Person person2 = new Person { FirstName = "Otto2", LastName = "Nozadze2", Age = 22 };
        Person person3 = new Person { FirstName = "Otto3", LastName = "Nozadze3", Age = 23 };
        Person person4 = new Person { FirstName = "Otto4", LastName = "Nozadze4", Age = 24 };
        Person person5 = new Person { FirstName = "Otto5", LastName = "Nozadze5", Age = 25 };
        Person person6 = new Person { FirstName = "Otto6", LastName = "Nozadze6", Age = 26 };

        // AddElement
        personList.AddElement(person1);
        personList.AddElement(person2);
        personList.AddElement(person3);

        // Count
        Console.WriteLine("Count: " + personList.Count); // 3

        // RemoveEllement
        PrintPersonList(personList);
        personList.RemoveElement(person1);
        PrintPersonList(personList);

        Console.WriteLine("Count: " + personList.Count); // 2

        // AddList 
        CustomList<Person> personList2 = new CustomList<Person>();
        personList2.AddElement(person5);
        personList2.AddElement(person6);
        personList.AddList(personList2);
        Console.WriteLine("Count: " + personList.Count); // 4

        // GetList
        CustomList<Person> getList;
        Console.Write("GetList (-1,2) " );
        Console.WriteLine(personList.GetList(-1, 2, out getList));

        Console.Write("GetList (0,3) ");
        personList.GetList(0, 3, out getList);
        PrintPersonList(getList);

        // InsertElement
        personList.InsertElement(2, person4);

        // InsertList
        Console.Write("\nBefore Insert:");
        PrintPersonList(personList);
        personList.InsertList(personList.Count-1, personList2);
        Console.Write("After Insert :");
        PrintPersonList(personList);

        // RemoveList
        personList2.AddList(personList);
        Console.Write("\nBefore Remove:  ");
        PrintPersonList(personList2);
        personList2.RemoveList(2, 3);
        Console.Write("After Remove:   ");
        PrintPersonList(personList2);
        
        // Clear
        personList2.Clear();
        Console.Write("\nFull List2 after Clear: "); 
        PrintPersonList(personList2);

        // GetElement
        personList.GetElement(2, out Person result1);
        Console.WriteLine( "\n GetElement [2] " + result1.FirstName);

        // Find
        Console.WriteLine( "Find Person4: " + personList.Find(person4).FirstName);



        CustomList<Organization> organizationList = new CustomList<Organization>();
        Organization org1 = new Organization { Name = "TBC"};
        Organization org2 = new Organization { Name = "BOG" };
        organizationList.AddElement(org1);
        organizationList.AddElement(org2);
        Console.WriteLine();
        PrintOrganizationList(organizationList);

    }

    private static void PrintPersonList(CustomList<Person> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i].FirstName + "  ");
        }
        Console.WriteLine();
    }

    private static void PrintOrganizationList(CustomList<Organization> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i].Name + "  ");
        }
        Console.WriteLine();
    }


}
