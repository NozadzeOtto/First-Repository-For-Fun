internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sheiyvane ricxvi: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0) { Console.WriteLine("=" + i + "*" + number / i + " - shedgenili"); return; }
        }

        Console.WriteLine("martivi");
    }
}