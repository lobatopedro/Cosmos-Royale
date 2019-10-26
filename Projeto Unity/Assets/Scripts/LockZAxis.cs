using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockZAxis : MonoBehaviour
{
    private Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;
        tempPos.z = 0;
        transform.position = tempPos;
    }
}
