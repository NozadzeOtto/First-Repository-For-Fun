internal class Program
{
    private static void Main(string[] args)
    {
        int N = 5;
        Console.WriteLine("Sheiyvanet " + N + " ricxvi: ");
        int sum = 0;
        int amount = 0;
        int result;

        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0) { sum += number; amount++; }
        }
        Console.WriteLine("\ndadebitebis sashualoa: ");
        Console.WriteLine(sum / amount);
    }
}