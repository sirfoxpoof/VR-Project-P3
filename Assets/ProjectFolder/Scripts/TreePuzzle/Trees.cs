using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
    public bool hasBark;
    public Transform treeBark;

    private Vector3 barkTarget;
    // Start is called before the first frame update
    void Start()
    {
        barkTarget = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(barkTarget, treeBark.position);
        if (distance < 1.3f)
        {
            hasBark = true;
        }
       
    }
}
