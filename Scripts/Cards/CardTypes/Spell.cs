using System;
using Effects;

namespace Cards.CardTypes
{
    public class Spell : Card
    {
        public Spell(String name, PlayCondition playCondition, Effects.Effect onPlayEffect)
        : base(name, "Spell", playCondition, onPlayEffect)
        {
        }

        public override int GetPower()
        {
            throw new Exception("Can't check power on spell");
        }

        public override String PrintData()
        {
            return "Card Type: " + GetCardType() + "\n Name: " + GetName() +
            "\n Play Condition: " +  GetPlayConditionInWords() + "\n Effect on Play: " + GetOnPlayEffectInWords();
        }
    }
}