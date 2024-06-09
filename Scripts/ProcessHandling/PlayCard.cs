using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UntitledCardGame.Scripts.ProcessHandling;
using UntitledCardGame.Scripts;
using UntitledCardGame.Scripts.Locations;


//only used for one function anymore, TODO move that function elsewhere and delete this
public class PlayCard
{
    //check this on every card each time the GameState updates
    public static bool IsCardPlayable(Card card)
    {
        PlayCondition playCondition = card.GetPlayConditionAsObject();
        Player cardOwner = card.GetOwner();

        if(!(playCondition.getFromWhere() == card.GetCurrentLocation()))
        {
            return false;
        }

        if(!(playCondition.getDiscardCounter() == cardOwner.GetCurrentDiscardCounter()))
        {
            return false;
        }

        if(!(playCondition.getSacrificeCounter() == cardOwner.GetCurrentSacrificeCounter()))
        {
            return false;
        }

        return true;
    }
}