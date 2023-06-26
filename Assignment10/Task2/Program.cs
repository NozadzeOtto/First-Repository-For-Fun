using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        var triangle1 = new Triangle();
        triangle1 = (Triangle)5;
        Console.WriteLine(triangle1.ToString());

        var triangle2 = new Triangle();
        triangle2.InputTriangle();
        Console.WriteLine(triangle2.ToString());
        Console.WriteLine("P = " + triangle2.Perimeter());
        Console.WriteLine("S = " + triangle2.Area());
    }
}