using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calc<T> : IGeneric<T>
    {
        public T Add(T item, T item2)
        {
            if (item == null || item2 == null) throw new ArgumentNullException("Null Type");
            T result = item + item2;

        }

        public T Multiply(T item, T item2)
        {
            throw new NotImplementedException();
        }

        public T Substract(T item, T item2)
        {
            throw new NotImplementedException();
        }
    }
}
