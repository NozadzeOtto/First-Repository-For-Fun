using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    public class Calculator
    {
        public static void Add(double x, double y)
        {
            Console.WriteLine($"{x}+{y} = {x + y}");
        }
        
        public static void Substract(double x, double y)
        {
            Console.WriteLine($"{x}-{y} = {x - y}");
        }

        public static void Multiply(double x, double y)
        {
            Console.WriteLine($"{x}*{y} = {x * y}");
        }

        public static void Divide(double x, double y)
        {
            Console.WriteLine($"{x}/{y} = {x / y}");
        }

        public static void Sqrt(double x)
        {
            Console.WriteLine($"Squre root of {x} is {Math.Sqrt(x)}");
        }

        public static void Pow(double x, double y)
        {
            Console.WriteLine($"{x}^{y} = {Math.Pow(x , y)}");
        }
    }
}
