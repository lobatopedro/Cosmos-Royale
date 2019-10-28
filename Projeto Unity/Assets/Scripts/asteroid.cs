using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float speed = 350.0f;
    private Rigidbody rb;
    private Vector2 screenBounds;
    private float x_axis;

    // Use this for initialization
    void Start()
    {
        x_axis = Random.Range(-40, 40);
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(x_axis, -speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < screenBounds.y * -1.2f)
        {
            Destroy(this.gameObject);
        }

    }
}