internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sheiyvane ricxvi: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) { count++;  Console.WriteLine(i); }
        }

        Console.WriteLine("Sul " + count + " gamyofi");
    }
}