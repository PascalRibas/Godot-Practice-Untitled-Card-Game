public class Attack
{
  private Creature attacker;
  private Creature defender;
  
  public Attack(attacker, defender)
  {
    this.attacker = attacker;
    this.defender = defender;
  }
  
  public Creature GetAttacker()
  {
    return attacker;
  }
  
  public void SetAttacker(Creature attacker)
  {
    this.attacker = attacker;
  }
  
  public Creature GetDefender()
  {
    return defender;
  }
 
  public void SetDefender(Creature defender)
  {
    this.defender = defender;
  }
}