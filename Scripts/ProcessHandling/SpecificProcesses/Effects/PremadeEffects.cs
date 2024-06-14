using System;

namespace Effects
{
  public class PremadeEffects
  {
    public static void Draw1(Player player)
    {
      ProcessHandling.MoveCards.DrawCardFromDeck(player);
    }
    
    public static void PopAnyCreature(Player player)
    {
      CardLocation enemyField = null;//IMPLEMENT LATER
      Creature target = AwaitTarget(player, enemyField);
      Combat.Destroy(target);
    }
    
    public static void AddCreatureFromDiscarded(Player player)
    {
      CardLocation
      Creature target = AwaitTargetPlayerDiscardPile(player);
      ProcessHandling.MoveCards.
    }
  }
}