//probably not using this
class TestCard : Card, Creature, OnPlayEffect //extends Card implements Creature and OnPlayEffect
{
  public int
  
  public void primaryEffect()
  {
    UntitledCardGame.Scripts.ProcessHandling.MoveCards.DrawCardFromDeck(Player super.GetOwner());
  }
  
	public void secondaryEffect()
	{
	  
	}
	
	public String EffectInWords()
	{
	  return "Test";
	}
}