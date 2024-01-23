using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pedestalPrefabs;

    public ColourPuzzle colourPuzzle;
    public bool hasAllOrbs = false;
    bool orbPuzzleDone;
    private void Update()
    {

        //scuffed manier :)
        if (pedestalPrefabs[0].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[1].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[2].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[3].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[4].GetComponent<Pedestal>().hasOrb)
        {
            
            if (!orbPuzzleDone)
            {
                orbPuzzleDone = true;
                hasAllOrbs = true;

                //play animation
                colourPuzzle.StartOrbPuzzle();
            }
        }
        else
        {
            
            hasAllOrbs = false;
        }
    }
}
