using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guide : MonoBehaviour
{
    public GameObject p1g0, p1g1, p1g2, p1g3, p1g4, p1g5, p1g6, p1g7, p1g8, p1g9, p2g0, p2g1, p2g2, p2g3, p2g4, p2g5, p2g6, p2g7, p2g8, p2g9;
    [SerializeField] Sprite[] guideColor;

    void Start()
    {
        p1g0.SetActive(false);
        p1g1.SetActive(false);
        p1g2.SetActive(false);
        p1g3.SetActive(false);
        p1g4.SetActive(false);
        p1g5.SetActive(false);
        p1g6.SetActive(false);
        p1g7.SetActive(false);
        p1g8.SetActive(false);
        p1g9.SetActive(false);
        p2g0.SetActive(false);
        p2g1.SetActive(false);
        p2g2.SetActive(false);
        p2g3.SetActive(false);
        p2g4.SetActive(false);
        p2g5.SetActive(false);
        p2g6.SetActive(false);
        p2g7.SetActive(false);
        p2g8.SetActive(false);
        p2g9.SetActive(false);
    }

    void Update()
    {
        
    }
}
