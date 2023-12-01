using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    private InputAtionMap inputActionMap;
    public Transform cam;
    public float speed, sensitivity, rotateUpdate;

    private Vector2 move;

    private InputAction moove, rotate; //naam is prachtig

    float time;


    private void Awake()
    {
        inputActionMap = new InputAtionMap();
    }

    private void OnEnable()
    {
        moove = inputActionMap.Player.Movement;
        moove.Enable();
        rotate = inputActionMap.Player.Rotate;
        rotate.Enable();
    }

    private void OnDisable()
    {
        moove.Disable();
        rotate.Disable();
    }

    private void FixedUpdate()
    {
        Walk();
        Rotation(rotate.ReadValue<Vector2>());
    }
    private void Walk()
    {
        move = moove.ReadValue<Vector2>();

        Vector3 _moveDirection = (cam.transform.forward * move.y + cam.transform.right * move.x) * Time.deltaTime;

        transform.position += _moveDirection * speed;
    }

    void Rotation(Vector2 _moveV2)
    {
        time += Time.deltaTime;

        if (_moveV2.y != 0 || _moveV2.x != 0)
        {
            if (time > rotateUpdate)
            {
                transform.Rotate(new Vector3(0, _moveV2.x, 0) * sensitivity);

                time = 0;
            }
        }
    }
}
