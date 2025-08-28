using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{
    private Rigidbody2D landerRigidbody2D;

    private void Awake()
    {
        landerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            float force = 700f;
            landerRigidbody2D.AddForce(force * transform.up);
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            float turnSpeed = 100;
            landerRigidbody2D.AddTorque(turnSpeed);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            float turnSpeed = -100;
            landerRigidbody2D.AddTorque(turnSpeed);
        }
    }

    private void Update()
    {
        
    }
}