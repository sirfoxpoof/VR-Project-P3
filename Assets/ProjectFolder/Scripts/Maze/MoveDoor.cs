using System.Collections;
using System.Collections.Generic;
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
        if (!doorMoved)
        {
            doorMoved = true;
            lever.SetTrigger("Open");
            leverOpposite.SetTrigger("Close");
            _animator.SetTrigger("Open");
            randomSoundPlayr.PlaySound();
        }
        else
        {
            doorMoved = false;
            lever.SetTrigger("Close");
            leverOpposite.SetTrigger("Open");
            _animator.SetTrigger("Close");
            randomSoundPlayr.PlaySound();
        }
    }
}
