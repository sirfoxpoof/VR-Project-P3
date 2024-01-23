using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSelector : MonoBehaviour
{
    [SerializeField] Material selectColour, normalColour, wrongColour;
    public ColourPuzzle cp;
    public int OrbIndex { get; set; }
    float delay = 0.5f;
    public AudioSource orbBoop, wrongOrbBoop;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            cp.PickedOrb(OrbIndex);
            OrbSelected();
            Debug.Log("help");
        }
    }

    public void OrbSelected()
    {
        //orbBoop.Play();
        gameObject.GetComponentInChildren<MeshRenderer>().material = selectColour;
        Invoke("DeselectOrb", delay);

        Debug.Log("help");
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
}
