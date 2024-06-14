using System.Collections.Generic;
using System.Linq;
using System;
using Cards.CardTypes;
using Godot;
using MatchNecessities;
using Locations;
using System.Threading.Tasks;
using System.Reflection.Metadata;

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

        GD.Print("Input number from 1 to 5:");
    }
}

public class Placeholder
{
    
    public static async Task<Creature> AwaitTarget (Player player, CardLocation cardLocation)
    {
        List<Card> cards = cardLocation.GetCards();
        int size = cards.Capacity;
        if (size == 0)
        {
            GD.PrintErr("Card was not playable!");
            throw new System.Exception();
        }

        GD.Print("Input target number from 1 to " + size + ":");

        Task<int> task = Main.HandleTargeting();
        int input = await task;

        return (Creature)cards.ElementAt(input-1);
    }
}
