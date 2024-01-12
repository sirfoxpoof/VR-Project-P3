using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    private bool doorMoved;
    public Animator lever;
    public Animator leverOpposite;
    private Animator _animator;
    public RandomSoundPlayr randomSoundPlayr;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void DoorMove()
    {
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    { 
        if (!doorMoved)
        {
            doorMoved = true;
            lever.SetTrigger("Open");
            leverOpposite.SetTrigger("Close");
            _animator.SetTrigger("Open");
            randomSoundPlayr.PlaySound();
            yield return new WaitForSeconds(2);
        }
        else
{
            doorMoved = false;
            lever.SetTrigger("Close");
            leverOpposite.SetTrigger("Open");
            _animator.SetTrigger("Close");
            randomSoundPlayr.PlaySound();
            yield return new WaitForSeconds(2);
}
    }
}
