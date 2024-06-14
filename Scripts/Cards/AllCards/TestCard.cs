class TestCard : Creature, OnPlayEffect //extends Creature implements OnPlayEffect
{
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