using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace _10_WriteADeck
{
    class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public Card(Values value, Suits suit)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get { return $"{Value} of {Suit}"; }
        }
        //ToString()를 재정의
        public override string ToString()
        {
            return Name;
        }
    }
}
