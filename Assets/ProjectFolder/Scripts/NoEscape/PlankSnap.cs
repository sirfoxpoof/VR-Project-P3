using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankSnap : MonoBehaviour
{
    public Transform plank, plankCollider;
    public GameObject fakePlank;

    private Vector3 plankTarget;

    private void Start()
    {
        plankTarget = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(plankTarget, plank.position);

        if (distance < 1f)
        {
            plankCollider.GetComponentInChildren<Collider>().isTrigger = false;
            fakePlank.SetActive(false);
        }
       
    }
}
