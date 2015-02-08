namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void OneAceClubToString()
        {
            Card aceClub = new Card(CardFace.Ace, CardSuit.Clubs);
            string result = aceClub.ToString();
            Assert.AreEqual("A♣", result);
        }

        [TestMethod]
        public void OneKingDiamondToString()
        {
            Card aceClub = new Card(CardFace.King, CardSuit.Diamonds);
            string result = aceClub.ToString();
            Assert.AreEqual("K♦", result);
        }

        [TestMethod]
        public void OneQueenHeartToString()
        {
            Card aceClub = new Card(CardFace.Queen, CardSuit.Hearts);
            string result = aceClub.ToString();
            Assert.AreEqual("Q♥", result);
        }

        [TestMethod]
        public void OneJackSpadeToString()
        {
            Card aceClub = new Card(CardFace.Jack, CardSuit.Spades);
            string result = aceClub.ToString();
            Assert.AreEqual("J♠", result);
        }
    }
}
