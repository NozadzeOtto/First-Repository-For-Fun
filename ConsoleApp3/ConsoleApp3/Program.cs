internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choose matrix size: ");
        Console.WriteLine("1. 2 x 2");
        Console.WriteLine("2. 3 x 3");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        decimal det = 0;

        int x;
        if (size == 1) { x = 2; } else if (size == 2) { x = 3; } else { Console.WriteLine("Wronf number!"); return;}

        // fill matrix
        int[,] array = new int[x, x];
        string printMatrix = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                Console.WriteLine($"[{i}.{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // print matrix
        Console.WriteLine("You entered matrix:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                printMatrix += $"{array[i, j]} ";
            }
            printMatrix += "\n";
        }
        Console.WriteLine(printMatrix);

        // determinant
        if(x == 1)
        { 
        det = array[0, 0] * array[1, 1] - array[0, 1] * array[1, 0];
        }
        else 
        {
            det += array[0, 0] * (array[1, 1] * array[2, 2] - array[1, 2] * array[2, 1]);
            det -= array[0, 1] * (array[1, 0] * array[2, 2] - array[1, 2] * array[2, 0]);
            det += array[0, 2] * (array[1, 0] * array[2, 1] - array[1, 1] * array[2, 0]);
        }
        Console.WriteLine($"Determinant is : {det}");
    }
}