namespace Poker
{
    using System;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            foreach (var item in hand.Cards)
            {
                string currentCard = item.ToString();
                for (int i = 0; i < 5; i++)
                {
                    if (i != hand.Cards.IndexOf(item))
                    {
                        if (currentCard == hand.Cards[i].ToString())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            int currentSuit = hand.Cards[0].Suit.GetHashCode();
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit.GetHashCode() != currentSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            
            foreach (var item in hand.Cards)
            {
                int count = 1;
                int currentCard = item.Face.GetHashCode();
                for (int i = 0; i < 5; i++)
                {
                    if (i != hand.Cards.IndexOf(item))
                    {
                        if (currentCard == hand.Cards[i].Face.GetHashCode())
                        {
                            count++;
                            if (count == 4)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
