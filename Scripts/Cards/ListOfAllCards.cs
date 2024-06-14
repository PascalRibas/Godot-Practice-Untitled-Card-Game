using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards
{
    /*
    Early Implementation of Cards using a class that simply lists them all.
    Should probably replace with a database or something similarly more readable in the future.
    */
    public class ListOfAllCards
    {
      private const List<Card> BaseCards = 
      {
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
        )
      };
    }
}