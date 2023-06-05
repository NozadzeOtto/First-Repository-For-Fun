internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sheiyvanet temperatura: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number < 0)
        {
            Console.WriteLine("yinavs");
        }
        else if (number > 0 && number <= 30)
        {
            Console.WriteLine("kargi amindia");
        }
        else
        {
            Console.WriteLine("cxela");
        }
    }
}