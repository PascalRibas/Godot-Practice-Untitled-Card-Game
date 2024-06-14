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

        public String EffectInWords()
        {
            return "Draw 1 Card.";
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

        public String EffectInWords()
        {
            return "Pop 1 opposing Creature of your choosing.";
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

        public String EffectInWords(int amount)
        {
            return "Lower 1 opposing Creature's attack by " + amount;
        }
    }

    class AddCreatureFromDiscarded : Effect
    {
        public void ApplyEffect(Player player)
        {
            Creature target = Placeholder.AwaitTarget(player, player.GetDiscardPile());
            ProcessHandling.MoveCards.MoveCard(target, player.GetHand());
        }

        public String EffectInWords()
        {
            return "";
        }
    }
}