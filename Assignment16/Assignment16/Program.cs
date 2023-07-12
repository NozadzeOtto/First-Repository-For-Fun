using Assignment16;

internal class Program
{
    private static void Main(string[] args)
    {
        int choosen;
        dynamic obj;
        dynamic type;
        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Substract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Sqrt");
        Console.WriteLine("6. Pow");

        var calculator = new Calculator();
        double x;
        double y;
        dynamic del;
        choosen = int.Parse(Console.ReadLine());
        switch (choosen)
        {
            case 1:
                Console.WriteLine("You Chose 'Add' operation.");
                Console.Write("Input x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Input y: ");
                y = double.Parse(Console.ReadLine());
                del = new DelegateCalculator(Calculator.Add);
                del(x, y);
                break;
            case 2:
                Console.WriteLine("You Chose 'Substract' operation.");
                Console.Write("Input x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Input y: ");
                y = double.Parse(Console.ReadLine());
                del = new DelegateCalculator(Calculator.Substract);
                del(x, y);
                break;
            case 3:
                Console.WriteLine("You Chose 'Multiply' operation.");
                Console.Write("Input x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Input y: ");
                y = double.Parse(Console.ReadLine());
                del = new DelegateCalculator(Calculator.Multiply);
                del(x, y);
                break;
            case 4:
                Console.WriteLine("You Chose 'Divide' operation.");
                Console.Write("Input x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Input y: ");
                y = double.Parse(Console.ReadLine());
                del = new DelegateCalculator(Calculator.Divide);
                del(x, y);
                break;
            case 5:
                Console.WriteLine("You Chose 'Sqrt' operation.");
                Console.Write("Input x: ");
                x = double.Parse(Console.ReadLine());
                del = new DelegateCalculatorSingle(Calculator.Sqrt);
                del(x);
                break;
            case 6:
                Console.WriteLine("You Chose 'Pow' operation.");
                Console.Write("Input x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Input y: ");
                y = double.Parse(Console.ReadLine());
                del = new DelegateCalculator(Calculator.Pow);
                del(x, y);
                break;
            default:
                break;
        }
    }
}



public delegate void DelegateCalculator(double n1, double n2);
public delegate void DelegateCalculatorSingle(double n1);