using System;
using System.Collections.Generic;
using System.Text;

namespace _03_PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            //1~4 사이의 임의의 숫자를 뽑는다.
            int value = random.Next(1, 5);

            //1 이면 스페이드를 반환
            if (value == 1) return "Spades";

            //2 이면 하트를 반환
            if (value == 2) return "Hearts";

            //3 이면 클로버를 반환
            if (value == 3) return "Clubs";

            //일치하는 값이 없으면 다이아몬드 반환
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
