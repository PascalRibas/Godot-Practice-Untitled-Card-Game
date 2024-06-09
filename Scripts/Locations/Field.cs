using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UntitledCardGame.Scripts.Locations
{
    public class Field : CardLocation
    {
        private List<Card> FieldCards;
        private Player player;
        public void Add(Card card)
        {
            FieldCards.Add(card);
        }

        public void Remove(Card card)
        {
            FieldCards.Remove(card);
        }

        public List<Card> GetCards()
        {
            return this.FieldCards;
        }
    }
}