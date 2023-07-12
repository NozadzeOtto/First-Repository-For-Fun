using System.Diagnostics.CodeAnalysis;

Console.WriteLine("sheiyvanet meore masivis zoma: ");
int size = int.Parse(Console.ReadLine());
int[] arrayInt = new int[size];

Console.WriteLine("sheiyvanet " + size + " ricxvi: ");
for (int i = 0; i < arrayInt.Length; i++) arrayInt[i] = int.Parse(Console.ReadLine());

string resultDemo = "";
int countDemo = 0;
string result = "";
int count = 0;
for (int i = 0; i < arrayInt.Length; i++)
{

    if (i < arrayInt.Length)
    {
        if (i == 0) resultDemo += arrayInt[i] + ", ";
        else
        {
            if (arrayInt[i] > arrayInt[i - 1])
            {
                resultDemo += arrayInt[i] + ", ";
                countDemo++;
                if (i == arrayInt.Length - 1)
                {
                    if (countDemo > count)
                    {
                        result = resultDemo;
                        resultDemo = arrayInt[i] + ", ";
                        count = countDemo;
                        countDemo = 0;
                    }
                }
            }
            else
            {
                if (countDemo > count)
                {
                    result = resultDemo;
                    resultDemo = arrayInt[i] + ", ";
                    count = countDemo;
                    countDemo = 0;
                }
            }
        }
    }
}

Console.WriteLine(result);