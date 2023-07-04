using BenchmarkDotNet.Attributes;
using Task3;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Random random = new Random();

        int DataSize = 1_000_000;
        HashSet<Person> PersonalData = new();


        for (int i = 0; i < DataSize; i++)
        {
            PersonalData.Add(Helper.CreateRandomPerson(random));
        }

        Console.WriteLine("Data in Hashset: " + PersonalData.Count);


        Person person2 = new Person() { ID = 333_333_333};
        var contains = PersonalData.Contains(person2);
        Console.WriteLine(contains);

        int number = 1;

        foreach (var item in PersonalData)
        {
            Console.WriteLine(number + ":\t" + item.Firstname + " " + item.Lastname + " " + item.ID + " " + item.Age + " " + item.PhoneNumber + "\n");
            number++;
        }

    }
}