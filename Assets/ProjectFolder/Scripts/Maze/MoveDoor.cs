using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    private bool doorMoved;
    [SerializeField]
    private Transform doorDirection;
    [SerializeField]
    private float moveSpeed;

    public void MoveDoorToDestination()
    {
        transform.position = doorDirection.position * moveSpeed * Time.deltaTime ; 
    }
    public void MoveDoorBack()
    {

    }
}
