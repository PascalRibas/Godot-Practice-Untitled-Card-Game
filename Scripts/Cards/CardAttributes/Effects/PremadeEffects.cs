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
            Creature target = Placeholder.AwaitTarget(player, enemyField);
            Combat.Destroy(target);
        }
    }

    class LowerAttackBy : EffectWithIntValue
    {
        public void ApplyEffect(Player player, int amount)
        {
            GameState gameState = ProcessHandling.GameHandler.GetGameState();
            CardLocation enemyField = gameState.GetOpponent(player).GetField();
            Creature target = Placeholder.AwaitTarget(player, enemyField);
            target.SetPower(target.GetPower() - amount);
        }
    }

    class AddCreatureFromDiscarded : Effect
    {
        public void ApplyEffect(Player player)
        {
            Creature target = Placeholder.AwaitTarget(player, player.GetDiscardPile());
            ProcessHandling.MoveCards.MoveCard(target, player.GetHand());
        }
    }

    class Placeholder
    {
        //placeholder function so the program doesn't crash
        public static Creature AwaitTarget (Player player, CardLocation cardLocation)
        {
            return new Creature("NotYetImplemented", new PlayCondition(), new Draw1(), 0);
        }
    }
}