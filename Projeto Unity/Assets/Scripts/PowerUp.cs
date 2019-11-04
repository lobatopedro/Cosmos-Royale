using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    
    public float multiplier = 1.7f;
    public float duration = 4f;
    public GameObject pickupEffect;
    private bool onEffect = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player)
    {
        
        Instantiate(pickupEffect, transform.position, transform.rotation);

        player.transform.localScale *= multiplier;

        transform.Find("Curve").GetComponent<MeshRenderer>().enabled = false;
        transform.Find("Cylinder").GetComponent<MeshRenderer>().enabled = false;
        transform.Find("Curve").GetComponent<Collider>().enabled = false;
        transform.Find("Cylinder").GetComponent<Collider>().enabled = false;
        transform.GetComponent<MeshRenderer>().enabled = false;
        transform.GetComponent<Collider>().enabled = false;

        yield return new WaitForSecondsRealtime(duration);
      
        player.transform.localScale /= multiplier;
            
        Destroy(gameObject);
    }
}
