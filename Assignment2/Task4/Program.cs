internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("height: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            string line = "";
            for (int k = 1; k <= number - i; k++) line += ' ';
            for (int j = 0; j < i; j++)
            {

                if (j > 0) line += "**";
                else { line += '*'; };

            }
            Console.WriteLine(line);
        }
        
    }
}