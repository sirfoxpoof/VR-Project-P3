using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPoint, plankSpawnPoint, player, plank;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            player.position = spawnPoint.position;
        }
        if (collision.transform.CompareTag("Plank"))
        {
            plank.position = plankSpawnPoint.position;
        }
    }
}
