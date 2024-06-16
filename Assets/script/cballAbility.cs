using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cballAbility : MonoBehaviour
{
    public GameObject nextSuit, nextValue;
    [SerializeField] Sprite[] suit, value;

    void Update()
    {
        switch (decks.cball)
        {
            case true:
                if (decks.newDeck.Count != 0)
                {
                    this.transform.position = new Vector3(-4.4f + 1.6f * draw.drawCount, -0.25f);
                    nextSuit.GetComponent<SpriteRenderer>().sprite = suit[decks.suit.IndexOf(decks.newDeck[0].suit)];
                    nextValue.GetComponent<SpriteRenderer>().sprite = value[decks.newDeck[0].value];
                }                
                break;
            case false:
                this.transform.position = new Vector3(-16, -0.25f);
                break;
        }
    }
}
