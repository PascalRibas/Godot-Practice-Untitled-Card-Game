//a collection of methods revolving around the combat step
public class Combat
{
  private static List<Attack> plannedAttacks = new List<Attack>();
  //TODO: move to a more appropriately named location
  public static void Destroy(Creature creature)
  {
    CardLocation Pile = creature.GetOwner().GetDiscardPile();
    ProcessHandling.MoveCards.MoveCard(creature, Pile);
  }
  
  //Basic Combat System
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
  
  public static void PlanAttack(Creature attacker, Creature defender)
  {
    Attack attack = new Attack(attacker, defender)
    PlanAttack(attack);
  }
  
  public static void PlanAttack(Attack attack)
  {
    plannedAttacks.Add(attack);
  }
  
  public static void CancelAttack(Attack attack)
  {
    plannedAttacks.Remove(attack);
  }
  
  public static void StartCombat()
  {
    foreach (Attack attack in plannedAttacks)
    {
      //insert Animation here
      Battle(attack.GetAttacker(), attack.GetDefender());
    }
  }
}