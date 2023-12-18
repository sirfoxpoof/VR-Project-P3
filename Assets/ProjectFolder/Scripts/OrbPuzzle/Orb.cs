using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pedestalPrefabs;
    public GameObject rock;

    public bool hasAllOrbs = false;
    private void Update()
    {

       /* for(int i = 0; i < pedestalPrefabs.Length; i++)
        {
            if (!pedestalPrefabs[i].GetComponent<Pedestal>().hasOrb)
            {
                hasAllOrbs = false;
                break;
            }
            else
            {
                hasAllOrbs = true;
            }
            
        }
        if (hasAllOrbs)
        {
            rock.SetActive(true);
        }
        else
        {
            rock.SetActive(false);
        }*/

        //scuffed manier :)
        if(pedestalPrefabs[0].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[1].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[2].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[3].GetComponent<Pedestal>().hasOrb && pedestalPrefabs[4].GetComponent<Pedestal>().hasOrb)
        {
            rock.SetActive(false);
        }
        else
        {
            rock.SetActive(true);
        }
    }
}
