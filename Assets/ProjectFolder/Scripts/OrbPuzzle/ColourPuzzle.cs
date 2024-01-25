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
    float delayTime = 1.3f;

    public Orb orb;
    public Animator orbAnimation;

    [Header("Hand")]
    [SerializeField] GameObject[] hands;



    void Start()
    {
        SetOrbIndex();
        orbAnimation.enabled = false;
    }

    public void StartOrbPuzzle()
    {
        hands[0].tag = "Hand";
        hands[1].tag = "Hand";


        // scripts aan: OrbSelector voor handen
        for (int i = 0; i < orbs.Length; i++)
        {
            orbs[i].GetComponent<OrbSelector>().enabled = true;
        }


        StartCoroutine("StartGame");

        orb.enabled = false;
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
        if(pick == colourOrder[pickNumber])
        {
            Debug.Log("Correct, next");
                pickNumber++;

            if (pickNumber < 5)
            {
                if(pickNumber == colourOrder.Count)
                {
                    StartCoroutine("StartGame");
                }
            }
            else
            {
                Debug.Log("YOU WON!");
                rock.SetActive(false);

                orbAnimation.enabled = true;

                orbAnimation.SetTrigger("AnimationOn");
                for (int i = 0; i < orbs.Length; i++)
                {
                    // orbs turning green
                    orbs[i].GetComponent<OrbSelector>().GameWon();
                }
                

                //win geluidje
            }
        }
        else
        {
            ResetGame();

            SetOrbIndex();
            StartCoroutine("StartGame");
        }
    }

    private void ResetGame()
    {
        for (int i = 0; i < orbs.Length; i++)
        {
            orbs[i].GetComponent<OrbSelector>().WrongOrb();
        }

        colourOrder.Clear();
    }
}
