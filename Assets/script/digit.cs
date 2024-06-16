using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digit : MonoBehaviour
{
    public GameObject deck_tens, deck_units, waste_tens, waste_units, player1_tens, player1_units, player2_tens, player2_units;

    [SerializeField] Sprite[] num;

    public static int player1Score = 0, player2Score = 0;

    void Update()
    {
        int deckTens = decks.newDeck.Count / 10;
        int deckUnits = decks.newDeck.Count % 10;
        int wasteTens = decks.waste.Count / 10;
        int wasteUnits = decks.waste.Count % 10;

        int player1Tens = 0;
        if (player1Score > 0)
        {
            player1Tens = player1Score / 10;
        }
        int player1Units = player1Score % 10;
        int player2Tens = 0;
        if (player2Score > 0)
        {
            player2Tens = player2Score / 10;
        }
        int player2Units = player2Score % 10;

        deck_tens.GetComponent<SpriteRenderer>().sprite = num[deckTens];
        deck_units.GetComponent<SpriteRenderer>().sprite = num[deckUnits];
        waste_tens.GetComponent<SpriteRenderer>().sprite = num[wasteTens];
        waste_units.GetComponent<SpriteRenderer>().sprite = num[wasteUnits];
        player1_tens.GetComponent<SpriteRenderer>().sprite = num[player1Tens];
        player1_units.GetComponent<SpriteRenderer>().sprite = num[player1Units];
        player2_tens.GetComponent<SpriteRenderer>().sprite = num[player2Tens];
        player2_units.GetComponent<SpriteRenderer>().sprite = num[player2Units];
    }
}
