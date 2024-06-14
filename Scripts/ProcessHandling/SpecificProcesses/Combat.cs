//a collection of methods revolving around the combat step
public class Combat
{
  //TODO: move to a more appropriately named location
  public static void Destroy(Creature creature)
  {
    CardLocation Pile = creature.GetOwner().GetDiscardPile();
    ProcessHandling.MoveCards.MoveCard(creature, Pile);
  }
  
  public static void Battle (Creature attacker, Creature defender)
  {
    int attack = attacker.GetPower();
    int defense = defender.GetPower();
    if(attack >= defense)
    {
      Destroy(defender);
    }
    if(defense >= attack)
    {
      Destroy(attacker);
    }
  }
}