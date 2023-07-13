using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calculator
    {
        public void Add(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        
        public void Substract(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiply(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Divide(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void SquareRoot(double x)
        {
            Console.WriteLine($"Squre root of {x} is {Math.Sqrt(x)}");
        }

        public void Pow(double x, double y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x , y)}");
        }
    }
}
