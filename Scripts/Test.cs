using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchNecessities;

public class Test
{
    private static List<Card> Decklist;

    public static void RunTest()
    {
        Decklist = new List<Card>();

        for(int i = 0; i < 6; i++)
        {
            foreach(Card card in Cards.ListOfAllCards.BaseCards)
            {
                Decklist.Add(card);
            }
        }

        Player player1 = new Player (Decklist, 0);
        Player player2 = new Player (Decklist, 1);

        ProcessHandling.GameHandler.StartMatch(player1, player2);
    }
}
