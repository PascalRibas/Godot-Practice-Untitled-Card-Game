using Godot;
using System;
using System.Collections.Generic;

public partial class Deck : Node
{
	public override void _Ready()
	{
		FillDeck();
		PrintDeck();
	}
	private List<Card> deckList = new List<Card>(30);
	//stuff for later
	private static Random rng = new Random();  

	public static void Shuffle<Card>(List<Card> list)  
	{
		int n = list.Count;  
		while (n > 1)
		{  
			n--;  
			int k = rng.Next(n + 1);  
			Card value = list[k];  
			list[k] = list[n];  
			list[n] = value;  
		}
	}

	public void FillDeck()
	{
		OnPlayEffect onPlayEffect = new TestCard();
		for(int i = 0; i < 5; i++)
		{
			deckList.Add(new Creature("Basic Creature", 10, new PlayCondition(), onPlayEffect));
			deckList.Add(new Spell("Basic Spell", false, new PlayCondition(), onPlayEffect));
			deckList.Add(new Spell("Basic QPSpell", true, new PlayCondition(), onPlayEffect));
		}
	}

	public void PrintDeck()
	{
		foreach(Card card in deckList)
		{
			String cardType = card.GetCardType();
			GD.Print(card.GetName());
			GD.Print(cardType);
			if(cardType == "Creature") GD.Print(card.GetPower());
			else if(cardType == "Spell") GD.Print(card.CheckIfQuickPlay());
		}
	}
}
