using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardDisplay : MonoBehaviour
{
    [SerializeField] Sprite[] suit, value, results;                                                                          

    public GameObject drawSuit, drawValue, result;

    public static bool busted = false;

    void Start()
    {
        this.transform.position = new Vector3(-6f + 1.6f * draw.drawCount, -0.25f);
        drawSuit.GetComponent<SpriteRenderer>().sprite = suit[decks.suit.IndexOf(decks.round[draw.drawCount].suit)];
        drawValue.GetComponent<SpriteRenderer>().sprite = value[decks.round[draw.drawCount].value];

        for (int i = 0; i < draw.drawCount; i++)
        {
            if (decks.round[draw.drawCount].suit == decks.round[i].suit)
            {
                busted = true;
                break;
            }
        }
        if (busted == false)
        {
            decks.suitAbility(decks.round[draw.drawCount].suit);
        } 
    }

    void OnMouseUp()
    {
        if (busted == true || decks.newDeck.Count == 0 || decks.monster == 0 && decks.target == false && decks.hook == false && decks.map == -1 && decks.sword == false)
        {
            draw.drawCount = -1;
            decks.cball = false;

            switch (busted)
            {
                case false:
                    //卡牌加入玩家牌堆

                    if (draw.round % 2 != 0)
                    {
                        for (int i = 0; i < decks.round.Count; i++)
                        {
                            decks.player1.Add(decks.round[i]);
                            if (decks.key == true && decks.tbox == true && decks.waste.Count > 0)
                            {
                                decks.waste = decks.ShuffleDeck(decks.waste);
                                decks.player1.Add(decks.waste[0]);
                                decks.waste.RemoveAt(0);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < decks.round.Count; i++)
                        {
                            decks.player2.Add(decks.round[i]);
                            if (decks.key == true && decks.tbox == true && decks.waste.Count > 0)
                            {
                                decks.waste = decks.ShuffleDeck(decks.waste);
                                decks.player2.Add(decks.waste[0]);
                                decks.waste.RemoveAt(0);
                            }
                        }
                    }

                    break;

                case true:
                    //卡牌加入廢牌堆
                    for (int i = 0; i < decks.anchor; i++)
                    {
                        if (draw.round % 2 != 0)
                        {
                            decks.player1.Add(decks.round[0]);
                        }
                        else
                        {
                            decks.player2.Add(decks.round[0]);
                        }
                        decks.round.RemoveAt(0);
                    }                    
                    for (int i = 0; i < decks.round.Count; i++)
                    {
                        decks.waste.Add(decks.round[i]);
                    }
                    busted = false;
                    break;
            }

            decks.round.Clear();

            //func 加入玩家花色堆
            decks.playerUpdate("p1");
            decks.playerUpdate("p2");

            decks.anchor = 0;
            decks.key = false;
            decks.tbox = false;
            draw.round++;

            if (decks.newDeck.Count == 0)
            {
                GameObject gameResult = Instantiate(result);
                if (digit.player1Score == digit.player2Score)
                {
                    gameResult.GetComponent<SpriteRenderer>().sprite = results[0];
                }
                else if (digit.player1Score > digit.player2Score)
                {
                    gameResult.GetComponent<SpriteRenderer>().sprite = results[1];
                }
                else
                {
                    gameResult.GetComponent<SpriteRenderer>().sprite = results[2];
                }
            }
        }
        
    }

    void Update()
    {
        if (draw.drawCount == -1)
        {
            Destroy(gameObject);
        }
    }

}
