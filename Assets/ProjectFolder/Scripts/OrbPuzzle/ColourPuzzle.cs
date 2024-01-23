using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColourPuzzle : MonoBehaviour
{
    [Header("Orb pedestal")]
    [SerializeField]
    public GameObject rock;


    [Header("Colour Puzzle")]
    [SerializeField] GameObject[] orbs;
    [SerializeField] List<int> colourOrder;
    [SerializeField] int puzzleRange;
    int pickNumber = 0;
    float delayTime = 1f;




    void Start()
    {
        //ResetGame();
        SetOrbIndex();
        StartCoroutine("StartGame");
    }

    public void StartOrbPuzzle()
    {
        //StartCoroutine("StartGame");
    }
    
    void SetOrbIndex()
    {
        for (int i = 0; i < orbs.Length; i++)
        {
            orbs[i].GetComponent<OrbSelector>().OrbIndex = i;
        }
    }

    IEnumerator StartGame()
    {
        pickNumber = 0;

        yield return new WaitForSeconds(delayTime);

        foreach(int colourIndex in colourOrder)
        {
            orbs[colourIndex].GetComponent<OrbSelector>().OrbSelected();
            yield return new WaitForSeconds(delayTime);
        }

        PickOrb();
    }

    void PickOrb()
    {
        int rnd = Random.Range(0, orbs.Length);
        orbs[rnd].GetComponent<OrbSelector>().OrbSelected();
        colourOrder.Add(rnd);
    }

    public void PickedOrb(int pick)
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH");
        if(pick == colourOrder[pickNumber])
        {
            Debug.Log("Correct, next");
            if(pickNumber < 7)
            {
                pickNumber++;
                if(pickNumber == colourOrder.Count)
                {
                    StartCoroutine("StartGame");
                }
            }
            else
            {
                Debug.Log("YOU WON!");
                rock.SetActive(false);
            }
        }
        else
        {
            ResetGame();

            StartCoroutine("StartGame");
        }
    }

    private void ResetGame()
    {
        colourOrder.Clear();
        orbs[1].GetComponent<OrbSelector>().WrongOrb();
    }
}
