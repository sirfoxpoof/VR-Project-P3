using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSelector : MonoBehaviour
{
    [SerializeField] Material selectColour, normalColour;
    float delay = 0.25f;

    public void SelectOrb()
    {
        gameObject.GetComponent<MeshRenderer>().material = selectColour;
        Invoke("DeselectOrb", delay);
    }

    public void DeselectOrb()
    {
        gameObject.GetComponent<MeshRenderer>().material = normalColour;
    }
}
