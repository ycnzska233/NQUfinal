using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hints : MonoBehaviour
{
    public GameObject hint;

    [SerializeField] Sprite[] suitHints;

    void Start()
    {
        hint.SetActive(false);
    }

    void Update()
    {
        if (draw.drawCount != -1)
        {
            hint.SetActive(true);

            int hintedSuit = 0;
            for(int i = 0; i < 10; i++)
            {
                if (decks.round[draw.drawCount].suit == decks.suits[i])
                {
                    hintedSuit = i;
                }
            }
            hint.GetComponent<SpriteRenderer>().sprite = suitHints[hintedSuit];

            if (cardDisplay.busted == true) { hint.GetComponent<SpriteRenderer>().sprite = suitHints[10]; }
        }
        else
        {
            hint.SetActive(false);
        }
    }
}
