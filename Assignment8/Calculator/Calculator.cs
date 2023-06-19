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
            decimal result = x;

            if (y == 0) return 1;

            for (int i = 0; i < y; i++) result *= x;

            if (y < 0) result = 1 / result;

            return result; ;
        }

        public static decimal Sqrt(decimal x)
        {
            if (x < 0) throw new Exception("Imposible to calculate square root!");

            // 64/2=32
            // 
            decimal result = x / 2;
            decimal result2 = result;

            while (true)
            {
                result2 = result;
                result = (result + x / result) / 2;
            }


            return result;
        }
    }
}
