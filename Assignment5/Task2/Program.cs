internal class Program
{
    private static void Main(string[] args)
    {
        char[] array = fillArray();

        Console.WriteLine("\nInputed Array :");
        foreach (char i in array) Console.Write("{0}, ", i);

        printResult(array, 'a');

        // fills array with console
        char[] fillArray()
        {
            Console.WriteLine("Input array length: ");
            int length = int.Parse(Console.ReadLine());
            char[] array = new char[length];
            Console.WriteLine("Input characters: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}]:");
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            return array;
        }

        // finds char in array and counts 
        int findCharInArray(char[] arr, char elm)
        {
            int count = 0;
            foreach (char j in arr) if (j == elm) count++;
            return count;
        }

        // prints how many times Char is found in array
        void printResult(char[] array, char element)
        {
            Console.WriteLine($"\n\n'{element}' can find in array {findCharInArray(array, element)} times");
        }
    }
}