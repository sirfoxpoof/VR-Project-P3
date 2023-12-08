using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pedestalPrefabs;

    private bool winOrbPuzzle;

    private void Update()
    {
        for (int i = 0; i < pedestalPrefabs.Length; i++) 
        {
            if (pedestalPrefabs[i].GetComponent<Pedestal>().hasOrb == true)
            {
                winOrbPuzzle = true;
            } 
        }

        if (winOrbPuzzle )
        {
            Debug.Log("WHOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOo");
        }
    }
}
