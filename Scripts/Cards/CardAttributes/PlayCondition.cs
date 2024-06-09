using System;
using System.Security.Cryptography.X509Certificates;

public class PlayCondition
{
	private CardLocation fromWhere = CardLocation.Hand;
	private int sacrificeCounter = 0;
	private int discardCounter = 0;

	public PlayCondition()
	{
		//For cards with "normal" Play Condition
	}

	public PlayCondition(CardLocation fromWhere, int sacrificeCounter, int discardCounter)
	{
		this.discardCounter = discardCounter;
		this.sacrificeCounter = sacrificeCounter;
		this.fromWhere = fromWhere;
	}

	public int getDiscardCounter()
	{
		return this.discardCounter;
	}

	public int getSacrificeCounter()
	{
		return this.sacrificeCounter;
	}

	public CardLocation getFromWhere()
	{
		return fromWhere;
	}

	public String PrintData()
	{
		return "";
	}
}
