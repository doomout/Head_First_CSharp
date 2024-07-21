using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace _10_WriteADeck
{
    class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();
        public Deck()
        {
            Reset();
        }
        public Deck(string filename)
        {
            //파일을 읽어 들일 StreamReader()을 생성
            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    //파일의 내용을 한 줄씩 읽어서 다음 4 작업을 수행
                    var nextCard = reader.ReadLine();

                    //String.Split() 메서드를 사용한다.
                    var cardParts = nextCard.Split(new char[] { ' ' });

                    //switch 식을 사용해 카드의 무늬를 가져온다.
                    var value = cardParts[0] switch
                    { 
                        "Ace" => Values.Ace,
                        "Two" => Values.Two,
                        "Three" => Values.Three,
                        "Four" => Values.Four,
                        "Five" => Values.Five,
                        "Six" => Values.Six,
                        "Seven" => Values.Seven,
                        "Eight" => Values.Eight,
                        "Nine" => Values.Nine,
                        "Ten" => Values.Ten,
                        "Jack" => Values.Jack,
                        "Queen" => Values.Queen,
                        "King" => Values.King,
                        _ => throw new InvalidDataException($"Unrecognized card suit: {cardParts[0]}") 
                    };

                    //switch 식을 사용해 카드의 숫자를 가져온다.
                    var suit = cardParts[2] switch
                    {
                        "Spades" => Suits.Spades,
                        "Clubs" => Suits.Clubs,
                        "Hearts" => Suits.Hearts,
                        "Diamonds" => Suits.Diamonds,
                        _ => throw new InvalidDataException($"Unrecognized card suit: {cardParts[2]}")
                    };
                    
                    //카드를 카드 덱에 추가한다.
                    Add(new Card(value, suit));
                }
            }
        }

        public void WriteCards(string filename)
        {
            using (var writer = new StreamWriter(filename))
            {
                for (int i = 0; i < Count; i++)
                    writer.WriteLine(this[i].Name);
            }
        }

        public void Reset()
        {
            Clear();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    Add(new Card((Values)value, (Suits)suit));
        }
        public Card Deal(int index)
        {
            Card cardToDeal = base[index];
            RemoveAt(index);
            return cardToDeal;
        }
        public void Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            while (copy.Count > 0)
            {
                int index = random.Next(copy.Count);
                Card card = copy[index];
                copy.RemoveAt(index);
                Add(card);
            }
        }
        public void Sort()
        {
            List<Card> sortedCards = new List<Card>(this);
            sortedCards.Sort(new CardComparerByValue());
            Clear();
            foreach (Card card in sortedCards)
            {
                Add(card);
            }
        }
    }
}
