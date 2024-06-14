using System.Collections.Generic;
using System.Linq;
using System;
using Cards.CardTypes;
using Godot;
using MatchNecessities;
using Locations;

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

        Console.WriteLine("Input number from 1 to 5:");
        int input = Console.ReadLine().ToInt();
        Hand hand = player1.GetHand();
        List<Card> HandList = hand.GetCards();
        PlayCard.Play(HandList.ElementAt(input-1));
    }
}

public class Placeholder
{
    
    public static Creature AwaitTarget (Player player, CardLocation cardLocation)
    {
        List<Card> cards = cardLocation.GetCards();
        int size = cards.Capacity;
        if (size == 0)
        {
            GD.PrintErr("Card was not playable!");
            throw new System.Exception();
        }

        Console.WriteLine("Input number from 1 to " + size);

        int input = Console.ReadLine().ToInt();

        return (Creature)cards.ElementAt(input-1);
    }
}
