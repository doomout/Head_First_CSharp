using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace _09_CardGroupQuery
{
    class Card : IComparable<Card>
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        //정렬을 위해 해당 메서드 구현
        public int CompareTo(Card other)
        {
            return new CardComparerByValue().Compare(this, other);
        }
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
