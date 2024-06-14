using System.Collections.Generic;
using MatchNecessities;

namespace Locations
{
    public class Field : CardLocation
    {
        private List<Card> FieldCards;
        //private Player player;

        public Field ()
        {
            FieldCards = new List<Card>();
        }

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