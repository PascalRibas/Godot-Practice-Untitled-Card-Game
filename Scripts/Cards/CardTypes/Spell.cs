using System;

namespace Cards.CardTypes
{
    public class Spell : Card
    {
        private bool isQuickPlay;
        public Spell(String name, bool isQuickPlay, PlayCondition playCondition, OnPlayEffect onPlayEffect)
        : base(name, "Spell", playCondition, onPlayEffect)
        {
            this.isQuickPlay = isQuickPlay;
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