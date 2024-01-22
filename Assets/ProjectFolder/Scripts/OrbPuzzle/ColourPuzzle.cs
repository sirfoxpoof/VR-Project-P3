using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPuzzle : MonoBehaviour
{
    [SerializeField] GameObject[] orbs;
    [Header("Colour Order")]
    [SerializeField] List<int> colourOrder;
    [SerializeField] int puzzleRange;
    float delayTime = 1f;


    void Start()
    {
        StartCoroutine("StartGame");
    }

    IEnumerator StartGame()
    {
        for(int i = 0; i < puzzleRange; i++)
        {
            yield return new WaitForSeconds(delayTime);
             PickOrb();
        }
    }

    void PickOrb()
    {
        int rnd = Random.Range(0, orbs.Length);
        orbs[rnd].GetComponent<OrbSelector>().OrbSelected();
        colourOrder.Add(rnd);
    }

    public void PickedOrb()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH");
    }
}
