using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnCollision : MonoBehaviour
{
    public GameObject test;
    private void OnTriggerEnter(Collider other)
    {
        test = other.gameObject;
        Debug.Log(test);
        if (other.gameObject.tag == "enemy")
        {
            Destroy(test);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}