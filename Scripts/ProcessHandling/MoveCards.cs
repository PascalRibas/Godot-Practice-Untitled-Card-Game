using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UntitledCardGame.Scripts.Locations;

namespace UntitledCardGame.Scripts.ProcessHandling
{
    public class MoveCards
    {
        public static void DrawCardFromDeck (Player player, GameState gameState)
        {
            Card drawnCard = gameState.GetDeck(player).pop();
            player.GetHand().AddCard(drawnCard);
        }
    }
}