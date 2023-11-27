using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    private InputAtionMap inputActionMap;
    public Rigidbody rb;
    public GameObject cameraHolder;
    public float speed, sprint, sensitivity, jumpHight;


    private Vector2 move, look;

    private InputAction movew, rotate;

    private float x, y;

    private void Awake()
    {
        inputActionMap = new InputAtionMap();
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        movew = inputActionMap.Player.Movement;
        movew.Enable();

        rotate = inputActionMap.Player.Rotate;
        rotate.Enable();
    }

    private void OnDisable()
    {
        movew.Disable();
        rotate.Disable();
    }

    private void FixedUpdate()
    {
        Walk();
        Rotate();
    }
    private void Walk()
    {
        move = movew.ReadValue<Vector2>() * (speed * Time.deltaTime);

        transform.Translate(move.x, 0, move.y);
    }

    private void Rotate()
    {
        look = rotate.ReadValue<Vector2>();

        x += look.x * sensitivity * Time.deltaTime;
        y -= look.y * sensitivity * Time.deltaTime;

        transform.localRotation = Quaternion.Euler(0, x, 0 * Time.deltaTime);
        cameraHolder.transform.localRotation = Quaternion.Euler(y, 0, 0 * Time.deltaTime);
    }
}
