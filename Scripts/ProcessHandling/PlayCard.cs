using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UntitledCardGame.Scripts.ProcessHandling;
using UntitledCardGame.Scripts;


    //list of static functions related to using cards
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
    public static void CardToField(Card card)
    {
        card.SetLocation(CardLocation.Field);
        GameHandler.GetGameState().Update();
    }
}