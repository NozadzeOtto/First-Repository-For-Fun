internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("sheiyvanet masivis zoma: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("sheiyvanet " + size + " elementi: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }

        for (int k = 0; k < size; k++)
        {
            for (int i = 0; i < size; i++)
            {
                int tempVar;

                if (i < array.Length - 1 && array[i] > array[i + 1])
                {
                    tempVar = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = tempVar;
                };
            }
        }


        //printing
        string result = "";
        foreach (int i in array)
            result += i + ", ";
        Console.WriteLine(result);
    }
}