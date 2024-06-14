using System;

namespace Effects
{
  public class PremadeEffects
  {
    public static void Draw1(Player player)
    {
      ProcessHandling.MoveCards.DrawCardFromDeck(player);
    }
  }
}