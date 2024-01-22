using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSelector : MonoBehaviour
{
    [SerializeField] Material selectColour, normalColour, wrongColour;
    public ColourPuzzle cp;
    float delay = 0.5f;
    public AudioSource orbBoop;

    public void SelectOrb()
    {
        cp.PickedOrb();
        OrbSelected();
    }

    public void OrbSelected()
    {
        orbBoop.Play();
        gameObject.GetComponentInChildren<MeshRenderer>().material = selectColour;
        Invoke("DeselectOrb", delay);
    }

    void DeselectOrb()
    {
        gameObject.GetComponentInChildren<MeshRenderer>().material = normalColour;
    }

    public void WrongOrb()
    {
        gameObject.GetComponentInChildren<MeshRenderer>().material = wrongColour;
        Invoke("DeselectOrb", delay);
    }
}
