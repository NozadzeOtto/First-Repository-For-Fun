using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        var fileName = "C:\\Users\\ONozadze\\source\\repos\\First-Repository-For-Fun\\Assignment16\\Task2\\Persons.txt";
        var result = new List<Person>();
        Contacts contacts = new Contacts();
        var type = typeof(Contacts);
        MethodInfo[] methodInfo = type.GetMethods();

        string? line;
        using (var fs = new StreamReader(fileName))
        {
            int id = 1;
            while ((line = fs.ReadLine()) != null)
            {
                Person person = new Person();
                while (true)
                {
                    person.Id = id;
                    person.FirstName = line;
                    person.LastName = fs.ReadLine();
                    person.Age = int.Parse(fs.ReadLine());
                    id++;
                    break;
                }
                contacts.Persons.Add(person);
            }
        }
        Console.WriteLine("Choose Search Method: ");

        int number = 1;
        foreach (var mi in methodInfo)
        {
            if (mi.DeclaringType == type)
            {
                Console.WriteLine(number + ". " + mi.Name);
                number++;
            }
        }

        int choosen = int.Parse(Console.ReadLine());
        var method = methodInfo[choosen - 1];
        Console.WriteLine($"You Chose '{method.Name}' method.");
        string[] parameters = new string[method.GetParameters().Length];
        for (int i = 0; i < method.GetParameters().Length; i++)
        {
            Console.Write("Input " + method.GetParameters()[i].Name + ": ");
            parameters[i] = Console.ReadLine();
        }

        dynamic del;
        switch (method.Name)
        {
            case "WithFirstName":
                del = Delegate.CreateDelegate(typeof(ContactDelegateName), contacts, method);
                result = del.Invoke(parameters[0]);
                break;
            case "WithLastName":
                del = Delegate.CreateDelegate(typeof(ContactDelegateName), contacts, method);
                result = del.Invoke(parameters[0]);
                break;
            case "WithFullName":
                del = Delegate.CreateDelegate(typeof(ContactDelegateName), contacts, method);
                result = del.Invoke(parameters[0]);
                break;
            case "WithAgeRange":
                del = Delegate.CreateDelegate(typeof(ContactDelegateAge), contacts, method);
                result = del.Invoke(int.Parse(parameters[0]), int.Parse(parameters[1]));
                break;
            default:
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Search Result:");
        Console.WriteLine();
        foreach (Person p in result)
        {
            Console.WriteLine($"{p.FirstName}\t{p.LastName}\t{p.Age}");
        }
    }
}

public delegate List<Person> ContactDelegateName(string Name);
public delegate List<Person> ContactDelegateAge(int fAge, int lAge);

