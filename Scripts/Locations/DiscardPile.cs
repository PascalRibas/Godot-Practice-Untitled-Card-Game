using System.Collections.Generic;

namespace Locations
{
    public class DiscardPile : CardLocation
    {
        private List<Card> DiscardedCards;
        public List<Card> GetCards()
        {
            return this.DiscardedCards;
        }

        public void Add(Card card)
        {
            DiscardedCards.Add(card);
        }

        public void Remove(Card card)
        {
            DiscardedCards.Remove(card);
        }
    }
}