using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pedestalPrefabs;
    public GameObject rock;

    private void Update()
    {
        for (int i = 0; i < pedestalPrefabs.Length; i++) 
        {
            if (pedestalPrefabs[i].GetComponent<Pedestal>().hasOrb == false)
            {
                return;
            }
            else
            {
                Destroy(rock);
            }
        }
    }
}
