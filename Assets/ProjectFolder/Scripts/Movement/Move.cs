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
    public float speedAcceleration, speed, sensitivity, rotateUpdate;

    private InputAction moove, rotate; 

    float time;

    Rigidbody rb;


    private void Awake()
    {
        inputActionMap = new InputAtionMap();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        Moove(moove.ReadValue<Vector2>());
        Rotation(rotate.ReadValue<Vector2>());
    }

    //movement
    void Moove(Vector2 _moveV2)
    {
        if (_moveV2.y != 0 || _moveV2.x != 0)
        {
            Vector3 _moveDirection = (transform.forward * _moveV2.y + transform.right * _moveV2.x) * Time.deltaTime;
            rb.AddForce(_moveDirection * speedAcceleration);

            SpeedControle();
        }

        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

    }

    //speedcontroler
    void SpeedControle()
    {
        Vector3 _speed = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        if (_speed.magnitude > speed)
        {
            Vector3 _speedLimited = _speed.normalized * speed;
            rb.velocity = new Vector3(_speedLimited.x, rb.velocity.y, _speedLimited.z);
        }
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
