using System;
using Godot;

public abstract class Card
{
	private String name;
	private String cardType;

	private PlayCondition playCondition;

	private OnPlayEffect onPlayEffect;

	public Card(String name, String cardType, PlayCondition playCondition, OnPlayEffect onPlayEffect)
	{
		this.name = name;
		this.cardType = cardType;
		this.playCondition = playCondition;
		this.onPlayEffect = onPlayEffect;
	}

	public String GetName()
	{
		return this.name;
	}

	public String GetCardType()
	{
		return this.cardType;
    }

    public String GetPlayConditionInWords()
    {
        return playCondition.PrintData();
    }

    public String GetOnPlayEffectInWords()
    {
        return onPlayEffect.EffectInWords();
    }

    public abstract int GetPower();
    public abstract bool CheckIfQuickPlay();

    public abstract String PrintData();

}

class Creature : Card
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

    public override bool CheckIfQuickPlay()
    {
        throw new Exception("Can't check quick play on creature");
    }

    public override String PrintData()
    {
        return "Card Type: " + GetCardType() + "\n Name: " + GetName() +
         "\n Play Condition: " +  GetPlayConditionInWords() + "\n Effect on Play: " + GetOnPlayEffectInWords()
         + "\n Power of Creature: " + GetPower();
    }
}

class Spell : Card
{
	private bool isQuickPlay;
	public Spell(String name, bool isQuickPlay, PlayCondition playCondition, OnPlayEffect onPlayEffect)
	: base(name, "Spell", playCondition, onPlayEffect)
	{
		this.isQuickPlay = isQuickPlay;
	}

    public override bool CheckIfQuickPlay()
    {
        return isQuickPlay;
    }

    public override int GetPower()
    {
        throw new Exception("Can't check power on spell");
    }

    public override String PrintData()
    {
        String quickPlay = "";
        if(CheckIfQuickPlay()) quickPlay = "Quick-Play ";
        return "Card Type: " + quickPlay + GetCardType() + "\n Name: " + GetName() +
         "\n Play Condition: " +  GetPlayConditionInWords() + "\n Effect on Play: " + GetOnPlayEffectInWords();
    }
}