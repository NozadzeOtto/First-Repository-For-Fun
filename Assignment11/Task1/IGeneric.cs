using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IGeneric<T>
    {
        T Add(T item, T item2);
        T Substract(T item, T item2);
        T Multiply(T item, T item2);
    }
}
