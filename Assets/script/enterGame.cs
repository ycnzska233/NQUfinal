using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enterGame : MonoBehaviour
{
    void OnMouseUp()
    {
        decks.anchor = 0;
        decks.cball=false;
        decks.key=false;
        decks.tbox = false;
        decks.monster = 0;
        decks.target = false;
        decks.hook = false;
        decks.map = -1;
        decks.sword = false;

        decks.player1.Clear();
        decks.player2.Clear();
        decks.playerUpdate("p1");
        decks.playerUpdate("p2");

        decks.waste.Clear();
        decks.newDeck.Clear();

        SceneManager.LoadScene("Game");

    }
}
