using System.Collections.Generic;
using Cards.CardTypes;
using Effects;

namespace Cards
{
    /*
    Early Implementation of Cards using a class that simply lists them all.
    Should probably replace with a database or something similarly more readable in the future.
    */
    public class ListOfAllCards
    {
      private const List<Card> BaseCards = 
      new List<Card>
      [
        new Creature
        (
          //Name:
          "TestCreature",
          //Power:
          5,
          //PlayCondition:
          new PlayCondition(),
          //Effect:
          PremadeEffects.Draw1()
        ),
        
        new Spell
        (
          //Name:
          "TestSpell",
          //IsQuickPlay:
          false,
          //PlayCondition:
          new PlayCondition(),
          //Effect:
          PremadeEffects.Draw1()
        )
      ];
    }
}