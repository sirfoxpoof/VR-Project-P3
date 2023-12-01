using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMeLater : MonoBehaviour
{
    public enum TestEnum
    {
        Idle,Attack,Move,Dancing,DeadOnTheGround
    }

    public TestEnum test;
    public TestEnum test2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(test == TestEnum.Idle) {
            print("I am idle!!");








        }
        else if(test == TestEnum.Attack)
        {
            print("I am attacking!");
        }
        else if (test == TestEnum.DeadOnTheGround) {
            print("I am dead on the ground!!");
        }
    }
}
