using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace _08_SuitsAndValues
{
    internal class Card
    {
        public Suits Suit {  get; private set; }
        public Values Value {  get; private set; }
        
        public Card(Values value, Suits suit)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get { return $"{Value} of {Suit}"; }
        }
    }
}
