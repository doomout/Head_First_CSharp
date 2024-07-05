using System;
using System.Runtime.CompilerServices;

namespace _08_JumbledCards
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            //Values : 카드 번호, Suits : 카드 무늬 
            Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            Console.WriteLine(card.Name);
        }
    }
}
