using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    public class MuhammadAli
    {
        public static void ThrowHands()
        {
            Console.WriteLine("Muhammad Ali could throw 12 punches in 2.8 seconds.");
        }
        public static void AliShuffle()
        {
            Console.WriteLine("The Ali Shuffle requires you to essentially 'shuffle' your feet back and forth, but at a very swift speed, enough to make it impossible for your opponent to ignore.");
        }
        public static void Quote(string number)
        {
            switch (int.Parse(number))
            {
                case 1:
                    Console.WriteLine("-\"I'm young, I'm handsome, I'm fast, I can't possibly be beat.\""); break;
                case 2:
                    Console.WriteLine("-\"Float like a butterfly, sting like a bee.\""); break;
                default: Console.WriteLine("-\"I am the greatest. I said that even before I knew I was.\""); break;
            }
        }

    }
}
