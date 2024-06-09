using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UntitledCardGame.Scripts.Locations
{
    public class DiscardPile
    {
        private List<Card> DiscardedCards;
        public List<Card> GetCards()
        {
            return this.DiscardedCards;
        }
    }
}