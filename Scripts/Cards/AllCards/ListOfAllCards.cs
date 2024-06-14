using System.Collections.Generic;
using Cards.CardTypes;
using Effects.PremadeEffects;

namespace Cards
{
    /*
    Early Implementation of Cards using a class that simply lists them all.
    Should probably replace with a database or something similarly more readable in the future.
    */
    public class ListOfAllCards
    {
        public static readonly List<Card> BaseCards = new List<Card>
        {
          new Creature
          (
            //Name:
            "TestCreature",
            //PlayCondition:
            new PlayCondition(),
            //Effect:
            new Draw1(),
            //Power:
            5
          ),

          new Spell
          (
            //Name:
            "TestSpell",
            //PlayCondition:
            new PlayCondition(),
            //Effect:
            new Draw1()
          ),

          new Spell
          (
            //Name:
            "TestSpell",
            //PlayCondition:
            new PlayCondition(),
            //Effect:
            new PopAnyCreature()
          )
        };

    }
}