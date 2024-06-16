using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map1 : MonoBehaviour
{
    public GameObject suit, value, guide, draws;
    [SerializeField] Sprite[] suits, values, color;

    void Update()
    {
        if (decks.map == 1)
        {
            this.transform.position = new Vector3(-4.4f + 1.6f * draw.drawCount, 1.5f);
            suit.GetComponent<SpriteRenderer>().sprite = suits[decks.suit.IndexOf(decks.waste[0].suit)];
            value.GetComponent<SpriteRenderer>().sprite = values[decks.waste[0].value];
            for (int i = 0; i < decks.round.Count; i++)
            {
                if (decks.round[i].suit == decks.waste[0].suit)
                {
                    guide.GetComponent<SpriteRenderer>().sprite = color[1];
                    break;
                }
            }
            decks.map--;
        }
        else if (decks.map == -1)
        {
            this.transform.position = new Vector3(-14, 1.5f);
            guide.GetComponent<SpriteRenderer>().sprite = color[0];
        }
    }

    void OnMouseUp()
    {
        decks.map = -1;
        
        decks.round.Add(decks.waste[0]);
        GameObject newCard = Instantiate(draws);
        draw.drawCount++;
        newCard.name = "draw" + draw.drawCount;
        decks.waste.RemoveAt(0);

        if (decks.monster != 0) { decks.monster--; }
    }
}
