using System;
using DeckofCards.Entities;
using System.Collections.Generic;
using System.Linq;
namespace DeckofCards
{
    public class Deck
    {
        public List<Card> CardSet;
        private static readonly Random rand = new Random();
        private static readonly object syncLock = new object();
        public Deck()
        {
            CardSet = new List<Card>();
            for (int i = 0; i < 4; i++)         
            {
                for (int j = 1; j < 14; j++)   
                {
                    CardSet.Add(new Card(i, j));
                }
            }
        }
        public List<Card> Draw(int howMany)
        {
            List<Card> userHand = new List<Card>();

            for (int i = 0; i < howMany; i++)
            {
                int index = RandomNumber(0, CardSet.Count);

                userHand.Add(new Card((int)CardSet[index].CardType, (int)CardSet[index].CardValue));
                CardSet.RemoveAt(index);
            }

            return userHand;
        }

        public int RandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return rand.Next(min, max);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
