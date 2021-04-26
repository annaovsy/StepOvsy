using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public enum CardType
    {
        Six = 0,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public enum CardSuit
    {
        Heart = 0,
        Diamond,
        Club,
        Spade
    }

    class Karta
    {
        public CardType type;
        public CardSuit suit;

        public Karta(CardType type, CardSuit suit)
        {
            this.type = type;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{type} {suit}";
        }
    }
}
