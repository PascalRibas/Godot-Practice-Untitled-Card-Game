using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locations;

namespace MatchNecessities
{
    public class Player
    {
        private int CurrentDiscardCounter;
        private int CurrentSacrificeCounter;
        private Hand hand;
        private DiscardPile pile;
        private Field field;
        private List<Card> deckList;
        private int playerNumber;

        public Player(List<Card> deckList, int playerNumber)
        {
            this.deckList = deckList;
            hand = new Hand();
            pile = new DiscardPile();
            field = new Field();
            this.playerNumber = playerNumber;
            CurrentDiscardCounter = 0;
            CurrentSacrificeCounter = 0;
        }

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

        public void IncrementDiscardCounter()
        {
            CurrentDiscardCounter++;
        }

        public void SetCurrentSacrificeCounter(int NewSacrificeCounter)
        {
            this.CurrentSacrificeCounter = NewSacrificeCounter;
        }

        public void IncrementSacrificeCounter()
        {
            CurrentSacrificeCounter++;
        }

        public DiscardPile GetDiscardPile()
        {
            return this.pile;
        }

        public Hand GetHand()
        {
            return this.hand;
        }

        public Field GetField()
        {
            return this.field;
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