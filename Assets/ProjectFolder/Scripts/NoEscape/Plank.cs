using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    public void PlankPickup()
    {
        transform.GetComponentInChildren<Collider>().isTrigger = true;
    }
    public void PlankLetGo()
    {
        transform.GetComponentInChildren<Collider>().isTrigger = false;
    }
}
