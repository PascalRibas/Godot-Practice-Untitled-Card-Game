using System;
using Godot;
using UntitledCardGame.Scripts;
using UntitledCardGame.Scripts.Locations;

public abstract class Card
{
	private String name;
	private String cardType;
	private PlayCondition playCondition;
	private OnPlayEffect onPlayEffect;
    private CardLocation currentLocation;
    private Player owner;

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

    public CardLocation GetCurrentLocation()
    {
        return this.currentLocation;
    }

    public void SetLocation(CardLocation location)
    {
        this.currentLocation = location;
    }

    public PlayCondition GetPlayConditionAsObject()
    {
        return this.playCondition;
    }
    public String GetPlayConditionInWords()
    {
        return playCondition.PrintData();
    }

    public String GetOnPlayEffectInWords()
    {
        return onPlayEffect.EffectInWords();
    }

    public Player GetOwner()
    {
        return this.owner;
    }

    public void setOwner(Player owner)
    {
        this.owner = owner;
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