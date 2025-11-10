using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSystemController
{
    CardSystemConfig _cardSystemConfig;
    private Card[] _cardsOnBoard;
    
    public Card[] CardsOnBoard => _cardsOnBoard;

    public CardSystemController(CardSystemConfig cardSystemConfig)
    {
        _cardSystemConfig = cardSystemConfig;
    }

    public void GenerateCards(LevelDataConfig levelData)
    {
        var cardFactory = new CardFactory(_cardSystemConfig);
        cardFactory.CreateCards(levelData);
    }
}
