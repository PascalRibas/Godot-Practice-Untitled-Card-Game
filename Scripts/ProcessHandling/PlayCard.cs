using MatchNecessities;
using ProcessHandling;

public class PlayCard
{
    //check this on every card each time the GameState updates
    public static bool IsCardPlayable(Card card)
    {
        PlayCondition playCondition = card.GetPlayConditionAsObject();
        Player cardOwner = card.GetOwner();

        if (!(playCondition.getFromWhere() == card.GetCurrentLocation()))
        {
            return false;
        }

        if (!(playCondition.getDiscardCounter() == cardOwner.GetCurrentDiscardCounter()))
        {
            return false;
        }

        if (!(playCondition.getSacrificeCounter() == cardOwner.GetCurrentSacrificeCounter()))
        {
            return false;
        }

        return true;
    }

    public static void Play(Card card)
    {
        if(card.GetCardType() == "Creature") MoveCards.MoveCard(card, card.GetOwner().GetField());
        card.ApplyEffect();
        if(card.GetCardType() == "Spell") MoveCards.MoveCard(card, card.GetOwner().GetDiscardPile());
    }
}