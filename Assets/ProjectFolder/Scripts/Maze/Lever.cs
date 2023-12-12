using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private Transform mazeDoor;

    private void Start()
    {
        mazeDoor.GetComponent<MoveDoor>();
    }

    // if lever is pulled and the bool is true then use void MoveDoorToDestination
    // if lever is pulled and the bool is false then use void MoveDoorBack
}
