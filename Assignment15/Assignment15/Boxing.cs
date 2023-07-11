using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    public class Boxing
    {
        public void StartRound(string opponent1, string opponent2)
        {
            Console.WriteLine("Starting round between {0} and {1}", opponent1, opponent2);
        }

        public void EndRound(string opponent1, string opponent2)
        {
            Console.WriteLine("Ending round between {0} and {1}", opponent1, opponent2);
        }

        public void WhosWinner(string winnerName)
        {
            Console.WriteLine("Winner is " + winnerName);
        }
    }
}
