using System;
using MatchNecessities;
using ProcessHandling;
using Cards.CardTypes;
using Effects;

namespace Effects.PremadeEffects
{
    class Draw1 : Effect
    {
        public void ApplyEffect(Player player)
        {
            ProcessHandling.MoveCards.DrawCardFromDeck(player);
        }
    }

    class PopAnyCreature : Effect
    {
        public void ApplyEffect(Player player)
        {
            GameState gameState = ProcessHandling.GameHandler.GetGameState();
            CardLocation enemyField = gameState.GetOpponent(player).GetField();
            Creature target = AwaitTarget(player, enemyField);
            Combat.Destroy(target);
        }
    }

    class LowerAttackBy : Effect
    {
        public void ApplyEffect(Player player, int amount)
        {
            GameState gameState = ProcessHandling.GameHandler.GetGameState();
            CardLocation enemyField = gameState.GetOpponent(player).GetField();
            Creature target = AwaitTarget(player, enemyField);
            target.SetPower(target.GetPower() - amount);
        }
    }

    class AddCreatureFromDiscarded : Effect
    {
        public void ApplyEffect(Player player)
        {
            Creature target = AwaitTarget(player, player.GetDiscardPile());
            ProcessHandling.MoveCards.MoveCard(target, player.GetHand());
        }
    }

}