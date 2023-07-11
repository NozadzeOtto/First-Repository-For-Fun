using System;
using System.Reflection.Metadata;

int matrixOneCol = 0;
int matrixOneRow = 0;
int matrixTwoCol = 0;
int matrixTwoRow = 0;

bool incorrect = true;
while (incorrect) {
    Console.WriteLine("Sheiyvanet pirveli matricis zoma:");
    Console.WriteLine("Columns: ");
    matrixOneCol = int.Parse(Console.ReadLine());
    Console.WriteLine("Rows: ");
    matrixOneRow = int.Parse(Console.ReadLine());

    Console.WriteLine("Sheiyvanet meore matricis zoma:");
    Console.WriteLine("Columns: ");
    matrixTwoCol = int.Parse(Console.ReadLine());
    Console.WriteLine("Rows: ");
    matrixTwoRow = int.Parse(Console.ReadLine());

    if (matrixOneRow != matrixTwoCol) { Console.WriteLine("matricebis gamravleba sheudzlebelia\n"); }
    else { incorrect = false;}
}

int[,] matrix1 = new int[matrixOneCol, matrixOneRow];
int[,] matrix2 = new int[matrixTwoCol, matrixTwoRow];
int[,] resultMatrix = new int[matrixOneCol, matrixOneCol];
int Temp = 0;
string printMatrix = "";

// fill first matrix
Console.WriteLine("shieyvanet pirveli matricis elementebi:");
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {

        Console.WriteLine($"[{i}][{j}]: ");
        matrix1[i, j] = int.Parse(Console.ReadLine());
    }
}


Console.WriteLine("\n");

// fill second matrix
Console.WriteLine("shieyvanet meore matricis elementebi:");
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {

        Console.WriteLine($"[{i}][{j}]: ");
        matrix2[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\n");

// print matrix
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        printMatrix += $"{matrix1[i, j]} ";
    }
    printMatrix += "\n";
}
Console.WriteLine(printMatrix + "  *");
printMatrix = "";

// print matrix
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        printMatrix += $"{matrix2[i, j]} ";
    }
    printMatrix += "\n";
}
Console.WriteLine(printMatrix + "  =");
printMatrix = "";

// multiply matrixes
for (int i = 0; i< matrix1.GetLength(0); i ++) 
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {

        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            Temp += matrix1[i, k] * matrix2[k, j];
            //Console.WriteLine($"{matrix1[i, k]} * {matrix2[k, j]}  [{i},{j},{k}]");
        }

        resultMatrix[i, j] = Temp;
        Temp = 0;
    }
}

// print matrix
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        printMatrix += $"{resultMatrix[i, j]} ";
    }
    printMatrix += "\n";
}
Console.WriteLine(printMatrix);
