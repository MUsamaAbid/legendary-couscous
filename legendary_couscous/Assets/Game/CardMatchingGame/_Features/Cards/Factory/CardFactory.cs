using System.Collections.Generic;

public class CardFactory
{
    CardSystemConfig _cardSystemConfig;
    public CardFactory(CardSystemConfig cardSystem)
    {
        _cardSystemConfig = cardSystem;
    }

    public Card[] CreateCards(LevelDataConfig levelData)
    {
        var cards = new List<Card>();
        
        return cards.ToArray();
    }
}
