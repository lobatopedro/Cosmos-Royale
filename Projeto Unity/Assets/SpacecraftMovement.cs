using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftMovement : MonoBehaviour
{
    float maxSpeed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
        void Update()
    {
        
        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical");

        transform.position = pos;

        
    }
}
