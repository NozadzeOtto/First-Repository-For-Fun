using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IGeneric<T>
    {
        public T Add(T item, T item2);
        public T Substract(T item, T item2);
        public T Multiply(T item, T item2);
    }
}
