using Task1;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        int choosen;
        var type = typeof(Calculator);
        MethodInfo[] methodInfo = type.GetMethods();
        int number = 1;
        Console.WriteLine("Choose Operation:");
        foreach (MethodInfo mi in methodInfo)
        {
            if (mi.DeclaringType == type)
            {
                Console.WriteLine(number + ". " + mi.Name);
                number++;
            }
        }
        var calculator = new Calculator();
        double x;
        double y;
        dynamic del;
        choosen = int.Parse(Console.ReadLine());
        var method = methodInfo[choosen - 1];
        Console.WriteLine($"You Chose '{method.Name}' operation.");
        double[] parameters = new double[method.GetParameters().Length];
        for (int i = 0; i < method.GetParameters().Length; i++)
        {
            Console.Write("Input " + method.GetParameters()[i].Name + ": ");
            parameters[i] = double.Parse(Console.ReadLine());
        }

        var delType = parameters.Length > 1 ? typeof(DelegateCalculator) : typeof(DelegateCalculatorSingle);
        del = Delegate.CreateDelegate(delType, calculator, method);

        if (parameters.Length > 1)
        {
            del(parameters[0], parameters[1]);
        }
        else
        {
            del(parameters[0]);
        }

    }
}


public delegate void DelegateCalculator(double n1, double n2);
public delegate void DelegateCalculatorSingle(double n1);