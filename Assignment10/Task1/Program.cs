using System.Text.RegularExpressions;
using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1.InputElements();
        Console.WriteLine( matrix1.ToString());
        Matrix matrix2 = new Matrix(2, 2);
        matrix2.InputElements();
        Console.WriteLine(matrix2.ToString());

        var addedMatrix = matrix1 + matrix2;
        Console.WriteLine("Add matrixes result : ");
        Console.WriteLine(addedMatrix.ToString());

        var substractedMatrix = matrix1 - matrix2;
        Console.WriteLine("Substract matrixes result : ");
        Console.WriteLine(substractedMatrix.ToString());

        var multipliedMatrix = matrix1 * matrix2;
        Console.WriteLine("Multiply matrixes result : ");
        Console.WriteLine(multipliedMatrix.ToString());

        var invertedMatrix = -matrix1;
        Console.WriteLine("Inverted matrixe1 result : ");
        Console.WriteLine(invertedMatrix.ToString());
    }

    
}