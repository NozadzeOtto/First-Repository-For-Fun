using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        var triangle1 = (Triangle)5;
        Console.WriteLine(triangle1.ToString());
        Console.WriteLine("triangle1 S = " + triangle1.Area());
        Console.WriteLine();

        var triangle2 = new Triangle();
        Console.WriteLine(triangle2.ToString());
        Console.WriteLine();
        Console.WriteLine("triangle2 P = " + triangle2.Perimeter());
        Console.WriteLine("triangle2 S = " + triangle2.Area());
        Console.WriteLine();

        Console.WriteLine("triangle1 > triangle2 : " + (triangle1 > triangle2));
        Console.WriteLine("triangle1 < triangle2 : " + (triangle1 < triangle2));
        Console.WriteLine("triangle1 == triangle2 : " + (triangle1 == triangle2));
        Console.WriteLine("triangle1 != triangle2 : " + (triangle1 != triangle2));
        Console.WriteLine();

        Console.WriteLine("triangle1 + triangle2 : " + (triangle1 + triangle2));
    }
}