﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08_JumbledCards
{
    //배열을 이용한 카드 한벌 만드는 방법
    internal class Deck
    {
        private readonly Card[] cards = new Card[52];
        public Deck() 
        {
            int index = 0;
            for (int suit  = 0; suit <= 3; suit++)
            {
                for(int value = 1; value <= 13; value++)
                {
                    cards[index++] = new Card((Values)value, (Suits)suit);
                }
            }
        }
        public void PrintCards()
        {
            for(int i = 0; i< cards.Length; i++) 
                Console.WriteLine(cards[i].Name);
        }
    }
}
