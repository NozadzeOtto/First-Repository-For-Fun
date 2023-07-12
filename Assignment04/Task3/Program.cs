//  first array
using System;

Console.WriteLine("sheiyvanet masivis zoma: ");
int size = int.Parse(Console.ReadLine());
int[] array1= new int[size];
Console.WriteLine("sheiyvanet " + size + " ricxvi: ");
for (int i = 0; i < array1.Length; i++) array1[i] = int.Parse(Console.ReadLine());


//  second array
Console.WriteLine("sheiyvanet meore masivis zoma: ");
int size2 = int.Parse(Console.ReadLine());
int[] array2= new int[size2];
Console.WriteLine("sheiyvanet " + size2 + " ricxvi: ");
for (int i = 0; i < array2.Length; i++) array2[i] = int.Parse(Console.ReadLine());

Console.WriteLine("sheiyvanet dalagebis principi : ASC/DESC");
string sortType = Console.ReadLine();

//  mergedArray for result
int[] mergedArray = new int[array2.Length + array1.Length];
for (int i = 0; i < mergedArray.Length; i++)
{
    if(i < array1.Length) mergedArray[i] = array1[i];
    else { mergedArray[i] = array2[i - array1.Length]; };
}

//  ASC ?
if (sortType.ToUpper() == "ASC")
{
    for (int k = 0; k < mergedArray.Length; k++)
    {
        for (int i = 0; i < mergedArray.Length; i++)
        {
            int tempVar;
            {
                if (i < mergedArray.Length - 1 && mergedArray[i] > mergedArray[i + 1])
                {
                    tempVar = mergedArray[i + 1];
                    mergedArray[i + 1] = mergedArray[i];
                    mergedArray[i] = tempVar;
                };
            }
        }
    }
}

//  DESC ?
else if (sortType.ToUpper() == "DESC") 
{
    for (int k = 0; k < mergedArray.Length; k++)
    {
        for (int i = 0; i < mergedArray.Length; i++)
        {
            int tempVar;
            {
                if (i < mergedArray.Length - 1 && mergedArray[i] < mergedArray[i + 1])
                {
                    tempVar = mergedArray[i + 1];
                    mergedArray[i + 1] = mergedArray[i];
                    mergedArray[i] = tempVar;
                };
            }
        }
    }
}
else { Console.WriteLine("araswori mnishvneloba! "); }


//Printing
string result = "";
for (int i = 0; i < mergedArray.Length; i++)
result += mergedArray[i] + ", ";
Console.WriteLine(result);