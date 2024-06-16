using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Deck5 : MonoBehaviour
{
    public GameObject card, guide, draws;
    [SerializeField] Sprite[] value, color;

    void Update()
    {
        if (decks.p1s5.Count != 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = value[decks.p1s5[decks.p1s5.Count - 1] - 2];
            if (decks.p1s5.Count > 1)
            {
                card.SetActive(true);
                card.GetComponent<SpriteRenderer>().sprite = value[decks.p1s5[decks.p1s5.Count - 2] - 2];
            }
            else { card.SetActive(false); }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = value[6];
            card.SetActive(false);
        }

        switch (guides.p1[5])
        {
            case 0:
                guide.SetActive(true);
                guide.GetComponent<SpriteRenderer>().sprite = color[0];
                break;
            case 1:
                guide.SetActive(true);
                guide.GetComponent<SpriteRenderer>().sprite = color[1];
                break;
            case 2:
                guide.SetActive(false);
                break;
        }
    }

    void OnMouseUp()
    {
        if (decks.target == true && guide.activeSelf == true)
        {
            int index = 0;
            for (int i = 0; i < decks.player1.Count; i++)
            {
                if (decks.player1[i].suit == decks.suit[5])
                {
                    if (decks.player1[i].value == decks.p1s5[decks.p1s5.Count - 1]) { index = i; }
                }
            }
            decks.waste.Add(decks.player1[index]);
            decks.player1.RemoveAt(index);
            decks.playerUpdate("p1");
            decks.target = false;
            for (int i = 0; i < 10; i++) { guides.p1[i] = 2; }
        }

        //hook
        if ((decks.hook == true || decks.sword == true) && guide.activeSelf == true)
        {
            int index = 0;
            for (int i = 0; i < decks.player1.Count; i++)
            {
                if (decks.player1[i].suit == decks.suit[5])
                {
                    if (decks.player1[i].value == decks.p1s5[decks.p1s5.Count - 1]) { index = i; }
                }
            }
            decks.round.Add(decks.player1[index]);
            GameObject newCard = Instantiate(draws);
            draw.drawCount++;
            newCard.name = "draw" + draw.drawCount;
            decks.player1.RemoveAt(index);
            decks.playerUpdate("p1");
            decks.hook = false;
            decks.sword = false;
            for (int i = 0; i < 10; i++) { guides.p1[i] = 2; }
            if (decks.monster > 0) { decks.monster--; }
        }
    }
}