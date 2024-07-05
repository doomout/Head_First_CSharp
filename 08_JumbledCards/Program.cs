using System;
using System.Runtime.CompilerServices;

namespace _08_JumbledCards
{
    internal class Program
    {
        //정적 읽기 전용으로 랜덤값을 공유한다.
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            //Values : 카드 번호, Suits : 카드 무늬 
            Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            Console.WriteLine(card.Name); //랜덤 카드 1장
            Console.WriteLine("----------------------------");
            Deck deck = new Deck();
            deck.PrintCards(); //전체 카드 출력(배열방식)
        }
    }
}
