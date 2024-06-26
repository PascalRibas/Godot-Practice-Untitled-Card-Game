using System.Collections.Generic;
using MatchNecessities;
using Cards;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Locations
{
	public class Hand : CardLocation
	{
		private List<Card> HandCards;
		//private Player player;
		
		public Hand ()
		{
			HandCards = new List<Card>();
		}
		
		public void Add(Card card)
		{
			HandCards.Add(card);
		}

		public void Remove(Card card)
		{
			HandCards.Remove(card);
		}

		public List<Card> GetCards()
		{
			return this.HandCards;
		}

		public void PlayByInt (int input)
		{
			PlayCard.Play(HandCards.ElementAt(input-1));
		}
	}
}
