using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Vector3 floorHeight;

    private void Start()
    {
        floorHeight = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
    }
    void Update()
    {
       /* float distance = Vector3.Distance(floorHeight, transform.position);
        if (distance < 0.1f)
        {
            transform.position = floorHeight;
        }*/

        if(transform.position.y < 0.1f)
        {
            transform.position = floorHeight;
        }
    }
}
