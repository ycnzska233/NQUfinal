using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnsDisplay : MonoBehaviour
{
    public GameObject playersTurn;

    [SerializeField] Sprite[] turns;

    void Start()
    {
        playersTurn.SetActive(true);
    }

    void Update()
    {
        if (draw.round % 2 != 0) { playersTurn.GetComponent<SpriteRenderer>().sprite = turns[0]; }
        else { playersTurn.GetComponent<SpriteRenderer>().sprite = turns[1]; }
    }
}
