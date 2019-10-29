﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidTextWarning : MonoBehaviour
{
    private Vector3 vector3;
    private float lifetime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-500, 100, 184);
        Destroy(this.gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        vector3 = new Vector3(-126, 100, 184);
        transform.position = Vector3.Lerp(transform.position, vector3, 0.1f);

    }
}
