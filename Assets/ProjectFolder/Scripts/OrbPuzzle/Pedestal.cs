using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{

    public bool hasOrb;
    public Transform orb;

    private Vector3 orbTarget;
    // Start is called before the first frame update
    void Start()
    {
        orbTarget = new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(orbTarget, orb.position);

        if (distance < 0.1f)
        {
            hasOrb = true;
            orb.GetComponent<AudioSource>().enabled = false;
        }
        else
        {
            hasOrb = false;
            orb.GetComponent<AudioSource>().enabled = true;
        }

    }
        
    
}
