//a collection of methods revolving around the combat step
public class Combat
{
  //TODO: move to a more appropriately named location
  public static void Destroy(Card card)
  {
    CardLocation Pile = card.GetOwner().GetDiscardPile();
    ProcessHandling.MoveCards.MoveCard(card, Pile);
  }
}