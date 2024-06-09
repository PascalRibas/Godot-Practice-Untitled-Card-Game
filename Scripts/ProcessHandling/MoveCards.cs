using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UntitledCardGame.Scripts.Locations;

namespace UntitledCardGame.Scripts.ProcessHandling
{
    public class MoveCards
    {
        public static void MoveCard(Card card, CardLocation to)
        {
            CardLocation from = card.GetCurrentLocation();
            from.Remove(card);
            to.Add(card);
        }
        public static void DrawCardFromDeck (Player player, GameState gameState)
        {
            Card drawnCard = gameState.GetDeck(player).pop();
            player.GetHand().Add(drawnCard);
        }

        public static void DiscardFromHand(Card card)
        {
            Player player = card.GetOwner();
            CardLocation to = player.GetDiscardPile();
            MoveCard(card, to);
        }

        public static void ManualDiscard(Card card)
        {
            Player player = card.GetOwner();
            DiscardFromHand(card);
            player.IncrementDiscardCounter();
        }

        public static void DiscardFromField(Card card)
        {
            Player player = card.GetOwner();
            CardLocation to = player.GetDiscardPile();
            MoveCard(card, to);
        }

        public static void ManualSacrifice(Card card)
        {
            Player player = card.GetOwner();
            DiscardFromField(card);
            player.IncrementSacrificeCounter();
        }
    }
}