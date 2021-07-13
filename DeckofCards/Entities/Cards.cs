using System;
using System.Collections.Generic;
using System.Text;

namespace DeckofCards.Entities
{
    public class Card
    {
        private  CardType type;
        private  CardValue value;
        public Card(int Type, int Value)
        {
            type = (CardType)(Type);
            value = (CardValue)(Value);
        }

        public CardType CardType
        {
            get { return type; }
            set { type =  value; }
        }
        public CardValue CardValue
        {
            get { return value; }
            set { this.value = value; }
        }
    }
    public enum CardType
    {
        Clubs = 0,
        Diamonds = 1,
        Hearts = 2,
        Spades = 3,
    }
    public enum CardValue
    {
        two = 1,
        three = 2,
        four = 3,
        five = 4,
        six = 5,
        seven = 6,
        eight = 7,
        nine = 8,
        ten = 9,
        jack = 10,
        queen = 11,
        king = 12,
        ace = 13,
    }

}
