using System.Collections.Generic;
using Cards;

public interface CardLocation
{
    public void Add(Card card);
    public void Remove(Card card);
    public List<Card> GetCards();
}