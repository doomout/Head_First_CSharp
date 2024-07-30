using System;
using System.IO;

namespace _12_PoolPuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kangaroo joey = new Kangaroo();
            int koala = joey.Wombat(joey.Wombat(joey.Wombat(1))); //0을 만듬
            try
            {
                Console.WriteLine((15 / koala) + " eggs per pound");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("G'Day Mate!");
            }
        }
    }
}

/**실행 결과
 G'Day Mate!
 */