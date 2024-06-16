using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw : MonoBehaviour
{
    public GameObject card;

    public static int drawCount = -1;
    public static int round = 1;

    void Start()
    {
        //生成60張卡牌
        for (int i = 0; i < 10; i++)
        {
            var cardSuit = decks.suit[i];
            if (i == 6) //人魚功能：加分
            {
                //初始分牌：50遊戲牌堆、10棄牌
                //每類型最小價值為初始棄牌
                decks.waste.Add(new card { suit = cardSuit, value = 4 });
                for (int j = 5; j < 10; j++)
                {
                    decks.newDeck.Add(new card { suit = cardSuit, value = j });
                    //Debug.Log("add suit" + i + "value" + j);
                }
            }
            else
            {
                decks.waste.Add(new card { suit = cardSuit, value = 2 });
                for (int j = 3; j < 8; j++)
                {
                    decks.newDeck.Add(new card { suit = cardSuit, value = j });
                    //Debug.Log("add suit" + i + "value" + j);
                }
            }
        }
        decks.newDeck = decks.ShuffleDeck(decks.newDeck);
        /*
        Debug.Log("complete create new deck");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("newDeck card" + i + " " + decks.newDeck[i].suit + decks.newDeck[i].value);
        }
        */
    }

    void OnMouseUp()
    {
        if (decks.newDeck.Count != 0 && drawCount < 9 && cardDisplay.busted == false && decks.target == false && decks.hook == false && decks.map == -1 && decks.sword == false)  
        {
            //抽卡
            decks.round.Add(decks.newDeck[0]);
            decks.newDeck.RemoveAt(0);

            //顯示卡牌
            GameObject newCard = Instantiate(card);
            drawCount++;
            newCard.name = "draw" + drawCount;

            /*
            //test
            Debug.Log("draw one card");
            for (int i = 0; i <= drawCount; i++)
            {
                Debug.Log("round card" + i + " " + decks.round[i].suit + decks.round[i].value);
            }
            for (int i = 0; i < 5; i++)
            {
                Debug.Log("newDeck card" + i + " " + decks.newDeck[i].suit + decks.newDeck[i].value);
            }
            */

            decks.cball = false;
            if (decks.monster > 0) decks.monster--;
        }                
    }
}