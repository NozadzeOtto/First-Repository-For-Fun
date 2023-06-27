using System.Text.RegularExpressions;
using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Matrix matrix1 = new Matrix();
        matrix1.InputElements();
        Console.WriteLine(matrix1.ToString());
        Matrix matrix2 = new Matrix();
        matrix2.InputElements();
        Console.WriteLine(matrix2.ToString());

        Matrix matrix3 = 5;
        Console.WriteLine("Implicit: Matrix = 5 ");
        Console.WriteLine(matrix3.ToString());

        var addedMatrix = matrix1 + matrix2;
        Console.WriteLine("Add matrices result : ");
        Console.WriteLine(addedMatrix.ToString());

        var substractedMatrix = matrix1 - matrix2;
        Console.WriteLine("Substract matrices result : ");
        Console.WriteLine(substractedMatrix.ToString());

        var multipliedMatrix = matrix1 * matrix2;
        Console.WriteLine("Multiply matrices result : ");
        Console.WriteLine(multipliedMatrix.ToString());

        var invertedMatrix = -matrix1;
        Console.WriteLine("Inverted matrix1 result : ");
        Console.WriteLine(invertedMatrix.ToString());

        Console.WriteLine("matrix1 equals to matrix2 : ");
        Console.WriteLine(matrix1.Equals(matrix2));



    }




}