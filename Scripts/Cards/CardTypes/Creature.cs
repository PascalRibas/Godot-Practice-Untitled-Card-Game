using System;

namespace Cards.CardTypes
{
  public class Creature : Card
  {
    private int power;
    public Creature(String name, int power, PlayCondition playCondition, OnPlayEffect onPlayEffect)
    : base(name, "Creature", playCondition, onPlayEffect)
    {
      this.power = power;
    }

    public override int GetPower()
    {
        return this.power;
    }

    public override String PrintData()
    {
        return "Card Type: " + GetCardType() + "\n Name: " + GetName() +
        "\n Play Condition: " +  GetPlayConditionInWords() + "\n Effect on Play: " + GetOnPlayEffectInWords()
        + "\n Power of Creature: " + GetPower();
    }
  }
}