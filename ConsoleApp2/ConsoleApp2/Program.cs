Console.WriteLine("Choose matrix size: ");
Console.WriteLine("1. 2 x 2");
Console.WriteLine("2. 3 x 3");
int size = Console.ReadLine();
Console.WriteLine("Enter elements:");
if (size == 1)
{
    int[,] array = new int[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.WriteLine($"[{i}.{j}]: ");
            array[i, j] = Console.ReadLine();
        }
    }
    Console.WriteLine("You entered matrix:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.WriteLine($"{array[i, j]}, {array[i, j + 1]}");
            Console.WriteLine($"{array[i + 1, j]}, {array[i + 1, j + 1]}");
        }
    }

}
else if (size == 2)
{

}
else { Console.WriteLine("Wrong number!"); }