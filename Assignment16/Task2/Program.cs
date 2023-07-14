using System.IO;
using System.Reflection;
using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        var fileName = "C:\\Users\\ONozadze\\source\\repos\\First-Repository-For-Fun\\Assignment16\\Task2\\Persons.txt";
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
                del = Delegate.CreateDelegate(typeof(ContactDelegateFirstName), contacts, method);
                del.Invoke(parameters[0]);
                break;
            case "WithLastName":
                del = Delegate.CreateDelegate(typeof(ContactDelegateLastName), contacts, method);
                del.Invoke(parameters[0]);
                break;
            case "WithFullName":
                del = Delegate.CreateDelegate(typeof(ContactDelegateFullName), contacts, method);
                del.Invoke(parameters[0]);
                break;
            case "WithAgeRange":
                del = Delegate.CreateDelegate(typeof(ContactDelegateAge), contacts, method);
                del.Invoke(int.Parse(parameters[0]), int.Parse(parameters[1]));
                break;
            default:
                break;
        }
    }
}

public delegate void ContactDelegateFirstName(string firstName);
public delegate void ContactDelegateLastName(string lastName);
public delegate void ContactDelegateFullName(string fullName);
public delegate void ContactDelegateAge(int fAge, int lAge);

