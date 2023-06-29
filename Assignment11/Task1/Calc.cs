using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calc<T> : IGeneric<T>
    {
        public T Add(T item, T item2)
        {
            if (typeof(T).IsClass && typeof(T) != typeof(string)) { throw new Exception("Addition on reference type is not supported"); }
            dynamic x = item;
            dynamic y = item2;
            return x + y;
        }

        public T Multiply(T item, T item2)
        {
            if ( typeof(T).IsClass ) { throw new Exception("Multiplication on reference type is not supported"); }
            dynamic x = item;
            dynamic y = item2;
            return x * y;
        }

        public T Substract(T item, T item2)
        {
            if (typeof(T).IsClass) { throw new Exception("Substraction on reference type is not supported"); }
            dynamic x = item;
            dynamic y = item2;
            return x - y;
        }
    }
}
