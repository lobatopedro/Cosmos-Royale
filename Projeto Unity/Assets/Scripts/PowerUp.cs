using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    
    public float multiplier = 1.7f;
    private float duration;
    private bool onEffect = true;
    private int random;

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

        duration = Random.Range(8.0f, 9.0f);

        random = Random.Range(0, 4);
        if(random == 0)
        {
            player.transform.localScale *= multiplier;
            yield return new WaitForSecondsRealtime(duration);
            player.transform.localScale /= multiplier;
        }
        if (random == 1)
        {
            player.transform.localScale /= multiplier;
            yield return new WaitForSecondsRealtime(duration);
            player.transform.localScale *= multiplier;
        }
        if (random == 2)
        {
            player.transform.GetComponent<PlayerMovement>().velocity *= multiplier;
            yield return new WaitForSecondsRealtime(duration);
            player.transform.GetComponent<PlayerMovement>().velocity /= multiplier;
        }
        if (random == 3)
        {
            player.transform.GetComponent<PlayerMovement>().velocity /= multiplier;
            yield return new WaitForSecondsRealtime(duration);
            player.transform.GetComponent<PlayerMovement>().velocity *= multiplier;
        }

        Destroy(gameObject);

    }
}
