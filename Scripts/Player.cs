using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UntitledCardGame.Scripts.Locations;

namespace UntitledCardGame.Scripts
{
    public class Player
    {
        private int CurrentDiscardCounter;
        private int CurrentSacrificeCounter;
        private Hand hand;
        private DiscardPile pile;
        private List<Card> deckList;
        private int playerNumber;

        public int GetCurrentDiscardCounter()
        {
            return this.CurrentDiscardCounter;
        }

        public int GetCurrentSacrificeCounter()
        {
            return this.CurrentSacrificeCounter;
        }
        
        public void SetCurrentDiscardCounter(int NewDiscardCounter)
        {
            this.CurrentDiscardCounter = NewDiscardCounter;
        }

        public void SetCurrentSacrificeCounter(int NewSacrificeCounter)
        {
            this.CurrentSacrificeCounter = NewSacrificeCounter;
        }

        public DiscardPile GetDiscardPile()
        {
            return this.pile;
        }

        public Hand GetHand()
        {
            return this.hand;
        }

        public List<Card> GetDeckList()
        {
            return this.deckList;
        }

        public int GetPlayerNumber()
        {
            return playerNumber;
        }
    }
}