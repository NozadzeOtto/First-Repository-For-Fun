using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static decimal Substract(decimal x, decimal y)
        {
            return x - y;
        }
        public static decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }
        public static decimal Devide(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Imposible to devide with 0!");
            }
            return x / y;
        }
        public static decimal Pow(decimal x, int y)
        {
            decimal result = 1;

            if (y == 0) return 1;

            for (int i = 0; i < y; i++) result *= x;

            if (y < 0) result = 1 / result;

            return result; ;
        }

        public static double Sqrt(double x)
        {   
            if (x < 0) throw new Exception("Imposible to calculate square root by Negative numbers!");

            //x=64
            double result = x / 2; // =32,16,8,4

            while (true)
            {
                double result2 = result; // = 8
                result = (result + x / result) / 2; // (8+64/8)/2 = 8 
                if(result2== result) break;
            }
            return result;
        }
    }
}
