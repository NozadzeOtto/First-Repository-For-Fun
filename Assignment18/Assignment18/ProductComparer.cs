using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            if(ReferenceEquals(x, y)) return true;
            if(x is null) return false;
            if(y is null) return false;
            if(x.GetType() != y.GetType()) return false;
            return x.Name == y.Name;
        }

        public int GetHashCode(Product obj)
        {
             return HashCode.Combine(obj.Id, obj.Name, obj.Price);
        }
    }
}
