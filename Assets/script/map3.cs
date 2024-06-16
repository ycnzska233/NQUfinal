using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map3 : MonoBehaviour
{
    public GameObject suit, value, guide, draws;
    [SerializeField] Sprite[] suits, values, color;

    void Update()
    {
        if (decks.map == 3)
        {
            this.transform.position = new Vector3(-4.4f + 1.6f * draw.drawCount, -2f);
            suit.GetComponent<SpriteRenderer>().sprite = suits[decks.suit.IndexOf(decks.waste[2].suit)];
            value.GetComponent<SpriteRenderer>().sprite = values[decks.waste[2].value];
            for (int i = 0; i < decks.round.Count; i++)
            {
                if (decks.round[i].suit == decks.waste[2].suit)
                {
                    guide.GetComponent<SpriteRenderer>().sprite = color[1];
                    break;
                }
            }
            decks.map--;
        }
        else if (decks.map == -1)
        {
            this.transform.position = new Vector3(-14, -2f);
            guide.GetComponent<SpriteRenderer>().sprite = color[0];
        }        
    }

    void OnMouseUp()
    {
        decks.map = -1;

        decks.round.Add(decks.waste[2]);
        GameObject newCard = Instantiate(draws);
        draw.drawCount++;
        newCard.name = "draw" + draw.drawCount;
        decks.waste.RemoveAt(2);

        if (decks.monster != 0) { decks.monster--; }
    }
}
