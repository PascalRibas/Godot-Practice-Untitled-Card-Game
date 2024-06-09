using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UntitledCardGame.Scripts.Locations
{
    public interface CardLocation
    {
        public void Add(Card card);
        public void Remove(Card card);
        public List<Card> GetCards();
    }
}