using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UntitledCardGame.Scripts.Locations
{
    public class Hand : CardLocation
    {
        private List<Card> HandCards;
        private Player player;
        public void Add(Card card)
        {
            HandCards.Add(card);
        }

        public void Remove(Card card)
        {
            HandCards.Remove(card);
        }

        public List<Card> GetCards()
        {
            return this.HandCards;
        }
    }
}