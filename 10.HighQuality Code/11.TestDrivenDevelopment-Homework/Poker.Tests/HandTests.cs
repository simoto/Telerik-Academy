namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TwoCardsHand()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.King, CardSuit.Diamonds));

            Hand hand = new Hand(cards);
            string result = hand.ToString();
            Assert.AreEqual("A♣ K♦", result);
        }

        [TestMethod]
        public void TwoEqualsCardsHand()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));

            Hand hand = new Hand(cards);
            string result = hand.ToString();
            Assert.AreEqual("A♣ A♣", result);
        }

        [TestMethod]
        public void NoCardsHand()
        {
            IList<ICard> cards = new List<ICard>();

            Hand hand = new Hand(cards);
            string result = hand.ToString();
            Assert.AreEqual("", result);
        }
    }
}
