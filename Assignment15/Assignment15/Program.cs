using Assignment15;
using System.Reflection;
using System.Reflection.Metadata;

int choosen;
dynamic obj;
dynamic type;
Console.WriteLine("Choose whoch class to work on:");
Console.WriteLine("1. Myke Tyson");
Console.WriteLine("2. Muhamed Ali");
Console.WriteLine("3. boxing");
choosen = int.Parse(Console.ReadLine());
switch (choosen)
{
    case 1:
        obj = new MikeTyson();
        type = typeof(MikeTyson); break;
    case 2:
        obj = new Muhammad();
        type = typeof(Muhammad); break;
    default:
        obj = new Boxing();
        type = typeof(Boxing); break;
}


MethodInfo[] methodInfo = type.GetMethods();
int number = 0;
Console.WriteLine("Choose method:");
foreach (MethodInfo mi in methodInfo)
{
    
    if (mi.DeclaringType == type) { 
        Console.WriteLine(number + ". " + mi.Name);
        number++;
    }
}
int choosenIndex = int.Parse(Console.ReadLine());
var method = methodInfo[choosenIndex];

object[] parameters = new object[method.GetParameters().Length];
for (int i = 0; i < method.GetParameters().Length; i++)
{
    Console.Write("Input parameter " + method.GetParameters()[i].Name + ": ");
    parameters[i] = Console.ReadLine();
}


method.Invoke(obj, parameters);