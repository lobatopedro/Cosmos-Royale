using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnemy : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject cometPrefab;
    public int wave;
    public float respawnTime;
    private float respawnProbability;
   
    
    //public GameObject meteoroPrefab;

    private float asteroidCounter;
    private Vector2 screenBounds;
    


    // Use this for initialization
    void Start()
    {
        wave = 6;
        asteroidCounter = 0.0f;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnAsteroid()
    {
        GameObject asteroid = Instantiate(asteroidPrefab) as GameObject;
        asteroid.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2, 184);
        asteroidCounter = asteroidCounter + 1;
        Debug.Log(asteroidCounter);
    }

    private void spawnComet()
    {
        GameObject comet = Instantiate(cometPrefab) as GameObject;
        comet.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2, 184);
    }


    IEnumerator asteroidWave()
    {

        while (true)
        {

            respawnTime = Random.Range(1.5f, 3);
            respawnProbability = Random.Range(1, 100);
            yield return new WaitForSeconds(respawnTime);

            if (respawnProbability <= 70)
            {
                spawnAsteroid();
            }
            else if (respawnProbability > 70 && respawnProbability < 95)
            {
                spawnComet();
            }
            else if (respawnProbability >= 95)
            {
                spawnComet();
            }
            
            
            
            //Asteroid Rain
            if (asteroidCounter == 20)
            {
                for (int i = 0; i <= wave; i++)
                {
                    yield return new WaitForSeconds(0.3f);
                    spawnAsteroid();
                }
                wave = wave + 2;
                asteroidCounter = 0;
                yield return new WaitForSeconds(5.0f);
            }


        }
    }
}