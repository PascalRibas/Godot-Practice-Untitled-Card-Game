using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Deck : Node, CardLocation
{
    private List<Card> deckList = new List<Card>(30);
    //stuff for later
    private static Random rng = new Random();

    public Deck(List<Card> deckList)
    {
        this.deckList = deckList;
    }

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

    /*
	Test Function, TODO move somewhere else
	public void FillDeck()
	{
		OnPlayEffect onPlayEffect = new TestCard();
		for(int i = 0; i < 5; i++)
		{
			deckList.Add(new Creature("Basic Creature", 10, new PlayCondition(), onPlayEffect));
			deckList.Add(new Spell("Basic Spell", false, new PlayCondition(), onPlayEffect));
			deckList.Add(new Spell("Basic QPSpell", true, new PlayCondition(), onPlayEffect));
		}
	}*/

    public void PrintDeck()
    {
        foreach (Card card in deckList)
        {
            String cardType = card.GetCardType();
            GD.Print(card.GetName());
            GD.Print(cardType);
            if (cardType == "Creature") GD.Print(card.GetPower());
        }
    }

    public List<Card> GetCards()
    {
        return deckList;
    }

    public void Remove(Card card)
    {
        this.deckList.Remove(card);
    }

    public void Add(Card card)
    {
        this.deckList.Add(card);
    }

    public Card pop()
    {
        Card card = deckList.ElementAt<Card>(0);
        Remove(card);
        return card;
    }
}
