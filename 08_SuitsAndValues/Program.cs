using System;
using System.Collections.Generic;

namespace _08_SuitsAndValues
{
    internal class Program
    {
        private static readonly Random random = new Random();
        
        static Card RandomCard()
        {
            return new Card((Values)random.Next(1,14), (Suits)random.Next(4));
        }
        
        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Console.Write("Enter number of cards: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
            {
                //입력한 수만큼 무작위로 카드 리스트 생성
                for (int i = 0; i < numberOfCards; i++)
                {
                    cards.Add(RandomCard());
                }
            }
            //생성한 카드를 콘솔에 출력
            PrintCards(cards);

            //비교자를 사용해 카드 목록을 정렬
            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n... sorting the cards .... \n");

            //정렬된 카드를 콘솔에 출력
            PrintCards(cards);
        }
    }
}
