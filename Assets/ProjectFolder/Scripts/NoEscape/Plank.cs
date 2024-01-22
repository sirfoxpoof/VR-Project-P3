using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    public void PlankPickup()
    {
        transform.GetComponentInChildren<Collider>().isTrigger = true;
    }
    public IEnumerator PlankLetGo()
    {
        yield return new WaitForSeconds(0.2f);
        transform.GetComponentInChildren<Collider>().isTrigger = false;
    }
}
