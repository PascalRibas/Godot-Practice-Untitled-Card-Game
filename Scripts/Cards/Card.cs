using System;
using Godot;
using MatchNecessities;
using Locations;
using System.Reflection.Metadata.Ecma335;
using Effects;


public abstract class Card
{
    private String name;
    private String cardType;
    private PlayCondition playCondition;
    private Effect onPlayEffect;
    private CardLocation currentLocation;
    private Player owner;

    public Card(String name, String cardType, PlayCondition playCondition, Effect onPlayEffect)
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
        return "";
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

    /*public String GetOnPlayEffectInWords()
    {
        return onPlayEffect.EffectInWords();
    }*/

    public Player GetOwner()
    {
        return this.owner;
    }

    public void setOwner(Player owner)
    {
        this.owner = owner;
    }

    public void ApplyEffect()
    {
        onPlayEffect.ApplyEffect(owner);
    }

    public abstract int GetPower();

    //public abstract String PrintData();

}