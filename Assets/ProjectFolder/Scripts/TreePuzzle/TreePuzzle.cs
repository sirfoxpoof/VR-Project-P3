using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePuzzle : MonoBehaviour
{
    public Transform[] trees;
    public GameObject orb;

    private void Start()
    {
        orb.SetActive(false);
    }

    private void Update()
    {
        if (trees[0].GetComponentInChildren<Trees>().hasBark && trees[1].GetComponentInChildren<Trees>().hasBark)
        {
            orb.SetActive(true);
        }
        else
        {
            orb.SetActive(false);
        }
    }
}
