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
      GameState gameState = ProcessHandling.GameHandler.GetGameState();
      CardLocation enemyField = gameState.GetOpponent(player).GetField();
      Creature target = AwaitTarget(player, enemyField);
      Combat.Destroy(target);
    }
    
    public static void AddCreatureFromDiscarded(Player player)
    {
      Creature target = AwaitTarget(player,  player.GetDiscardPile());
      ProcessHandling.MoveCards.MoveCard(target, player.GetHand());
    }
    
    public static void LowerAttackBy (Player player, int amount)
    {
      
    }
  }
}