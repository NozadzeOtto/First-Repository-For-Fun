internal class Program
{
    private static void Main(string[] args)
    {
        char[] array = fillArray();

        Console.Write("\nInputed Array : ");
        foreach (char i in array) Console.Write("{0}, ", i);

        findCharInArray(array, 'a');

        // fills array with console
        char[] fillArray()
        {
            Console.WriteLine("Input array length: ");
            int length = int.Parse(Console.ReadLine());
            if (length <= 0) { Console.WriteLine("Length must be grater than 0!"); }
            char[] array = new char[length];
            Console.WriteLine("Input characters: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}]:");
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            return array;
        }

        // finds char in array and counts 
        int findCharInArray(char[] arr, char elm)
        {
            int count = 0;
            foreach (char j in arr) if (j == elm) count++;
            printResult(elm, count);
            return count;
        }

        // prints how many times Char is found in array
        void printResult(char element, int count)
        {
            Console.WriteLine($"\n\nWe found {element} {count} times in the array");
        }
    }
}