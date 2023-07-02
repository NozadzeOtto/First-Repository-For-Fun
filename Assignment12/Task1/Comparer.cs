using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class StringComparer: IComparer<string>
    {
        public int Compare(string x, string y)
        { 
            return x.CompareTo(y); 
        }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person  x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
