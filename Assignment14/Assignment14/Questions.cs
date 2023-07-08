using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    public class Questions
    {
        public string Question { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public int Score { get; set; }
        public int RealAnswerKey { get; set; }

        public Questions() 
        { 
            PossibleAnswers = new List<string>();
        }

    }

    
}
