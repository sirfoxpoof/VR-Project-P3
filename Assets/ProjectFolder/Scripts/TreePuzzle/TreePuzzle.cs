using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePuzzle : MonoBehaviour
{
    public Transform[] trees;
    public GameObject orb;

    private void Update()
    {
        if (trees[0].GetComponent<Trees>().hasBark && trees[1].GetComponent<Trees>().hasBark)
        {
            orb.SetActive(true);
        }
        else
        {
            orb.SetActive(false);
        }
    }
}
