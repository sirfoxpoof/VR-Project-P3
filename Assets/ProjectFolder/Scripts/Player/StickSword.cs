using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSword : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bush"))
        {
            Destroy(other.gameObject);
        }
    }
}
