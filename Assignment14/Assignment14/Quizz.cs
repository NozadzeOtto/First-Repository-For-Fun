using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    public class Quizz
    {
        public string Name { get; set; }
        public List<Questions> Questions { get; set; }

        public Quizz() 
        {
            Questions = new List<Questions>();
        }
    }
}
