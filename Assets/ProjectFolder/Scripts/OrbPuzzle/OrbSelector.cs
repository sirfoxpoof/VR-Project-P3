using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSelector : MonoBehaviour
{
    [SerializeField] Material selectColour, normalColour, wrongColour, winColour;
    public ColourPuzzle cp;
    public int OrbIndex { get; set; }
    float delay = 0.5f;
    public AudioSource orbBoop, wrongOrbBoop;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            OrbSelected();
            cp.PickedOrb(OrbIndex);
        }
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
        wrongOrbBoop.Play();
        gameObject.GetComponentInChildren<MeshRenderer>().material = wrongColour;
        Invoke("DeselectOrb", delay);
    }

    public void GameWon()
    {
        gameObject.GetComponentInChildren<MeshRenderer>().material = winColour;
    }
}
