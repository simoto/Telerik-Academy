namespace Poker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void IsValidCardsTest()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Queen, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Jack, CardSuit.Spades));
            cards.Add(new Card(CardFace.Five, CardSuit.Diamonds));
            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsValidHand(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsNotStraightFlushTest()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Queen, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Jack, CardSuit.Spades));
            cards.Add(new Card(CardFace.Five, CardSuit.Diamonds));
            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsStraightFlush(hand);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsStraightFlushTest()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.King, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Queen, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Jack, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsStraightFlush(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsFourOfAKindTest()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsFourOfAKind(hand);
            Assert.AreEqual(true, result);
        }
    }
}
