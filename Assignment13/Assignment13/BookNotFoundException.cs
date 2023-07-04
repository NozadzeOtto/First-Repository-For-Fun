using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class BookNotFoundException : ApplicationException
    {
        public BookNotFoundException(string message ) : base(message)
        {
            
        }
    }
}
