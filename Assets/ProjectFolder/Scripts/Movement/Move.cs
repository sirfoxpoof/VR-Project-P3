using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    /*private InputAtionMap inputActionMap;
    private InputAction movement;

    private void Start()
    {
        inputActionMap = new InputAtionMap();

    }
    private void OnEnable()
    {
        movement = inputActionMap.Player.Movement;
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }*/


    private InputAtionMap input;
    public Rigidbody rb;
    public float speed, sprint, sens, jumpHight;

    private Vector2 move;

    private InputAction movew;

    private void Awake()
    {
        input = new InputAtionMap();
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        movew = input.Player.Movement;
        movew.Enable();
    }

    private void OnDisable()
    {
        movew.Disable();
    }

    private void FixedUpdate()
    {
        Walk();
    }

    private void Walk()
    {
        move = movew.ReadValue<Vector2>() * (speed * Time.deltaTime);

        transform.Translate(move.x, 0, move.y);
    }
}
