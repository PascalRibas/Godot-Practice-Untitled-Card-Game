using MatchNecessities;

namespace ProcessHandling
{
	public class GameState
	{
		const int HAND_SIZE = 5;
		private Deck[] decks;
		private Player player1;
		private Player player2;
		public void StartGame(Player player1, Player player2)
		{
			this.player1 = player1;
			this.player2 = player2;
			decks = new Deck[] { new Deck(player1.GetDeckList()), new Deck(player2.GetDeckList()) };

			decks[0].Shuffle();
			decks[1].Shuffle();

			for (int i = 0; i < HAND_SIZE; i++)
			{
				MoveCards.DrawCardFromDeck(player1, this);
			}

			for (int i = 0; i < HAND_SIZE; i++)
			{
				MoveCards.DrawCardFromDeck(player2, this);
			}
		}

		public void Update()
		{
			foreach (Card card in player1.GetHand().GetCards())
			{
				if (PlayCard.IsCardPlayable(card))
				{
					//TODO: Connect to Frontend
				}
			}

			foreach (Card card in player2.GetHand().GetCards())
			{
				if (PlayCard.IsCardPlayable(card))
				{
					//TODO: Connect to Frontend
				}
			}

			foreach (Card card in player1.GetDiscardPile().GetCards())
			{
				if (PlayCard.IsCardPlayable(card))
				{
					//TODO: Connect to Frontend
				}
			}

			foreach (Card card in player2.GetDiscardPile().GetCards())
			{
				if (PlayCard.IsCardPlayable(card))
				{
					//TODO: Connect to Frontend
				}
			}

			foreach (Card card in this.decks[0].GetCards())
			{
				if (PlayCard.IsCardPlayable(card))
				{
					//TODO: Connect to Frontend
				}
			}

			foreach (Card card in this.decks[1].GetCards())
			{
				if (PlayCard.IsCardPlayable(card))
				{
					//TODO: Connect to Frontend
				}
			}
		}

		public Deck GetDeck(Player player)
		{
			//player numbers are 0 and 1
			return decks[player.GetPlayerNumber()];
		}

		public Player GetOpponent(Player player)
		{
			if (player.Equals(player1))
			{
				return player2;
			}

			return player1;
		}
	}
}
