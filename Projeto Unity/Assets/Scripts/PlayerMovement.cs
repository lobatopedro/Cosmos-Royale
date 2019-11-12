using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Joystick joystick;
    private Rigidbody spaceCraft;

    public float velocity = 1500f;
    public float maxSpeed = 500f;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        spaceCraft = GetComponent<Rigidbody>();
    }

    void Update()
    {
        thrust(joystick.Horizontal, joystick.Vertical);
    }

    private void thrust(float joystickX, float joystickY){

        Vector3 forceX = transform.right * joystickX;
        Vector3 forceY = transform.up * joystickY;

        spaceCraft.AddForce(-forceX * velocity);
        spaceCraft.AddForce(forceY * velocity);
    }



}
