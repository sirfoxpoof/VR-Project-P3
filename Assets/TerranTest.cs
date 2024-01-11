using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TerranTest : MonoBehaviour
{
    public int pixelError = 50;
    public bool setPixelError;


    void Update()
    {
        if (setPixelError){
            foreach (Transform t in transform)
            {
                if (t.GetComponent<Terrain>())
                {
                    t.GetComponent<Terrain>().heightmapPixelError = pixelError;
                }
            }
            setPixelError = false;
        }
    }
}
