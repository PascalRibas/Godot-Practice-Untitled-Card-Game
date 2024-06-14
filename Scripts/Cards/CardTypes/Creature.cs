//might roll back to multi-level inheritance instead
public interface Creature
{
  public String GetCardType()
  {
    return "Creature";
  }
  public int power { get; set; };
}