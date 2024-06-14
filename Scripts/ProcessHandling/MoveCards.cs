using MatchNecessities;
using Godot;

namespace ProcessHandling
{
    public class MoveCards
    {
        //does this one classify as self-commenting
        public static void MoveCard(Card card, CardLocation to)
        {
            CardLocation from = card.GetCurrentLocation();
            from.Remove(card);
            to.Add(card);
        }


        public static void DrawCardFromDeck(Player player, GameState gameState)
        {
            Card drawnCard = gameState.GetDeck(player).pop();
            player.GetHand().Add(drawnCard);
        }


        public static void DrawCardFromDeck(Player player)
        {
            GameState gameState = ProcessHandling.GameHandler.GetGameState();
            Card drawnCard = gameState.GetDeck(player).pop();
            player.GetHand().Add(drawnCard);
            GD.PrintErr("Player " + player.GetPlayerNumber() + " drew " + drawnCard.PrintData());
        }

        //probably made obsolete by MoveCard
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

        public static void SendFromField(Card card)
        {
            Player player = card.GetOwner();
            CardLocation to = player.GetDiscardPile();
            MoveCard(card, to);
        }

        public static void ManualSacrifice(Card card)
        {
            Player player = card.GetOwner();
            SendFromField(card);
            player.IncrementSacrificeCounter();
        }
    }
}