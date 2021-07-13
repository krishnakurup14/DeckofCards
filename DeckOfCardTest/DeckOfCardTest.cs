using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckofCards.Entities;
using DeckofCards;
using System.Collections.Generic;
namespace DeckOfCardTest
{
    [TestClass]
    public class DeckOfCardTest
    {
        public Deck deckOfCards = new Deck();

        [TestMethod]
        public void DeckInstance_CardCount_Return52()
        {
            int cardCount = deckOfCards.CardSet.Count;
            Assert.AreEqual(52, cardCount);
        }
        [TestMethod]
        public void Draw_TestCardCountDrawn_ReturnHandCountEqualToHowMany()
        {
            int count = 37; 
            List<Card> actual = deckOfCards.Draw(count);

            Assert.AreEqual(actual.Count, count);       
            CollectionAssert.AllItemsAreUnique(actual); 
        }
    }
}
