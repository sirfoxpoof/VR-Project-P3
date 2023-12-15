using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pedestalPrefabs;
    public GameObject rock;

    public static int pedestalsRight = 0;
    private void Update()
    {
        if(pedestalsRight == pedestalPrefabs.Length)
        {
            rock.SetActive(false);
        }
    }
}
