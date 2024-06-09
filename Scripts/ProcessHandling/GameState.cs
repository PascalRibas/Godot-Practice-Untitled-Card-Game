using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using UntitledCardGame.Scripts.ProcessHandling;

namespace UntitledCardGame.Scripts
{
    public class GameState
    {
        const int HAND_SIZE = 4;
        private Deck[] decks;
        private Player player1;
        private Player player2;
        public void StartGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            decks = new Deck[] {new Deck(player1.GetDeckList()), new Deck(player2.GetDeckList())};

            for(int i = 0; i < HAND_SIZE; i++)
            {
                MoveCards.DrawCardFromDeck(player1, this);
            }

            for(int i = 0; i < HAND_SIZE; i++)
            {
                MoveCards.DrawCardFromDeck(player2, this);
            }
        }

        public void Update()
        {
            foreach (Card card in player1.GetHand().GetCards())
            {
                if(PlayCard.IsCardPlayable(card))
                {
                    //TODO: Connect to Frontend
                }
            }

            foreach (Card card in player2.GetHand().GetCards())
            {
                if(PlayCard.IsCardPlayable(card))
                {
                    //TODO: Connect to Frontend
                }
            }

            foreach (Card card in player1.GetDiscardPile().GetCards())
            {
                if(PlayCard.IsCardPlayable(card))
                {
                    //TODO: Connect to Frontend
                }
            }

            foreach (Card card in player2.GetDiscardPile().GetCards())
            {
                if(PlayCard.IsCardPlayable(card))
                {
                    //TODO: Connect to Frontend
                }
            }

            foreach (Card card in this.decks[0].ListContents())
            {
                if(PlayCard.IsCardPlayable(card))
                {
                    //TODO: Connect to Frontend
                }
            }

            foreach (Card card in this.decks[1].ListContents())
            {
                if(PlayCard.IsCardPlayable(card))
                {
                    //TODO: Connect to Frontend
                }
            }
        }

        public Deck GetDeck(Player player)
        {
            return decks[player.GetPlayerNumber()-1];
        }
    }
}