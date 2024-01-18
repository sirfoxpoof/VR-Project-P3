using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPuzzle : MonoBehaviour
{
    [SerializeField] GameObject[] orbs;
    [Header("Colour Order")]
    [SerializeField] List<int> colourOrder;


    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        PickOrb();
    }

    void PickOrb()
    {
        int rnd = Random.Range(0, orbs.Length);
       // orbs[rnd].SelectOrb();
        colourOrder.Add(rnd);
    }
}
