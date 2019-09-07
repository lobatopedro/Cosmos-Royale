using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Joystick joystick;
    private Rigidbody spaceCraft;

    public int velocity = 50;
    public float maxSpeed = 50;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        spaceCraft = GetComponent<Rigidbody>();
    }

    void Update()
    {
        thrust(joystick.Horizontal, joystick.Vertical);
        clampSpeed();
    }

    private void clampSpeed()
    {
        //Esse método limita a velocidade da nave de acordo com o valor colocado em maxSpeed.
        float x = Mathf.Clamp(spaceCraft.velocity.x, -maxSpeed, maxSpeed);
        float y = Mathf.Clamp(spaceCraft.velocity.y, -maxSpeed, maxSpeed);

        spaceCraft.velocity = new Vector3(x, y);
    }

    private void thrust(float joystickX, float joystickY){

        Vector3 forceX = transform.right * joystickX;
        Vector3 forceY = transform.up * joystickY;
        
        spaceCraft.AddForce(forceY * velocity);
        spaceCraft.AddForce(-forceX * velocity);
    }



}
