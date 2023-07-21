using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class MyEnumerator <T>
    {
        int nIndex;
        MyList<T> collection;
        public MyEnumerator(MyList<T> coll)
        {
            collection = coll;
            nIndex = -1;
        }

        public bool MoveNext()
        {
            nIndex++;
            return (nIndex < collection.Count);
        }

        public T Current => collection[nIndex];
    }
}
