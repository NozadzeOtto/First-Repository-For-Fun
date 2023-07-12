internal class Program
{
    private static int bigger;

    private static void Main(string[] args)
    {
        //first array
        Console.WriteLine("sheiyvanet masivis zoma: ");
        int size = int.Parse(Console.ReadLine());
        string[] arrayString = new string[size];

        Console.WriteLine("sheiyvanet " + size + " elementi: ");
        for (int i = 0; i < arrayString.Length; i++) arrayString[i] = Console.ReadLine();


        //second array
        Console.WriteLine("sheiyvanet meore masivis zoma: ");
        int size2 = int.Parse(Console.ReadLine());
        int[] arrayInt = new int[size2];

        Console.WriteLine("sheiyvanet " + size2 + " ricxvi: ");
        for (int i = 0; i < arrayInt.Length; i++) arrayInt[i] = int.Parse(Console.ReadLine());

        int biggerIndex = size > size2 ? size : size2;

        string[] resultArray = new string[biggerIndex * 2];
        for (int i = 0; i < biggerIndex; i++)
        {
            if (i < arrayString.Length) resultArray[i * 2] = arrayString[i];
            if (i < arrayInt.Length) resultArray[i * 2 + 1] = arrayInt[i].ToString();
        }


        //Printing
        string result = "";
        for (int i = 0; i < resultArray.Length; i++)
            result += resultArray[i] + ", ";
        Console.WriteLine(result);
    }
}