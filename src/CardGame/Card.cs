using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Card(Value value, Suit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        public Suit Suit { get; }

        public Value Value { get; }

        public bool Equals(ICard other)
        {
            return Suit == other.Suit && Value == other.Value;
        }
    }
}
