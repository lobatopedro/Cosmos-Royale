using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    
    public float multiplier = 1.7f;
    public float duration = 4f;
    private bool onEffect = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -300);
            StartCoroutine(Pickup(other));
            //transform.Find("Curve").GetComponent<MeshRenderer>().enabled = false;
            //transform.Find("Cylinder").GetComponent<MeshRenderer>().enabled = false;
            //transform.Find("Curve").GetComponent<Collider>().enabled = false;
            //transform.Find("Cylinder").GetComponent<Collider>().enabled = false;
            //transform.GetComponent<MeshRenderer>().enabled = false;
            
        }
    }

    IEnumerator Pickup(Collider player)
    {
       
        player.transform.localScale *= multiplier;    
       

        yield return new WaitForSecondsRealtime(duration);
      
        player.transform.localScale /= multiplier;
        Destroy(gameObject);

    }
}
