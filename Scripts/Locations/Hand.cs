using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UntitledCardGame.Scripts.Locations
{
    public class Hand
    {
        private List<Card> HandCards;
        private Player player;
        public void AddCard(Card card)
        {
            HandCards.Add(card);
        }

        public List<Card> GetCards()
        {
            return this.HandCards;
        }
    }
}