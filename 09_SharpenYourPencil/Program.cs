using System;
using System.Linq;

namespace _09_SharpenYourPencil
{
    internal class Program
    {
        static string Output(Suits suit, int number)  => $"Suit is {suit} and number is {number}";
        static void Main(string[] args)
        {
            var deck = new Deck();

            var processedCards = deck
                .Take(3) //앞에서 3개
                .Concat(deck.TakeLast(3)) //뒤에서 3개
                .OrderByDescending(card => card.Value) //내림차순으로 정렬
                .Select(card => card.Value switch
                {
                    Values.King => Output(card.Suit, 7),
                    Values.Ace => $"It's an ace! {card.Suit}",
                    Values.Jack => Output((Suits)card.Suit - 1, 9),
                    Values.Two => Output(card.Suit, 18),
                    _ => card.ToString(),
                });

            foreach (var output in processedCards)
            {
                Console.WriteLine(output);
            }
        }
    }
}
/**실행 결과
Suit is Hearts and number is 7
Queen of Hearts
Suit is Diamonds and number is 9
Three of Spades
Suit is Spades and number is 18
It's an ace! Spades
 */