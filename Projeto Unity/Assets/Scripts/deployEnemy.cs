using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnemy : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject cometPrefab;
    public GameObject meteorPrefab;
    public GameObject warningPrefab;
    public GameObject warningTextAsteroidPrefab;
    public GameObject warningTextCometPrefab;
 
    private int asteroidWaves;
    private int cometWaves;
    private float respawnTime;
    private float respawnProbability;

    private float cometCounter;
    private float asteroidCounter;
    private Vector2 screenBounds;


    // Use this for initialization
    void Start()
    {
        asteroidWaves = 6;
        asteroidCounter = 0.0f;

        cometWaves = 3;
        cometCounter = 0.0f;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
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
        Vector3 vector3 = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2.5f, 184);

        GameObject warning = Instantiate(warningPrefab) as GameObject;
        GameObject comet = Instantiate(cometPrefab) as GameObject;
        comet.transform.position = vector3;
        warning.transform.position = new Vector3(vector3.x, 520, 184);
        
        cometCounter += 1;
        Debug.Log(cometCounter);
    }

    private void spawnMeteor()
    {
        GameObject meteor = Instantiate(meteorPrefab) as GameObject;
        meteor.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 1.5f, 184);
    }

    IEnumerator enemyWave()
    {

        while (true)
        {

            respawnTime = Random.Range(0.5f, 3);
            respawnProbability = Random.Range(1, 100);
            yield return new WaitForSeconds(respawnTime);

            if (respawnProbability <= 70)
            {
                if (asteroidCounter == 13) //Asteroid Rain
                {
                    GameObject warning = Instantiate(warningTextAsteroidPrefab) as GameObject;
                    yield return new WaitForSeconds(1.0f);

                    for (int i = 0; i <= asteroidWaves; i++)
                    {
                        yield return new WaitForSeconds(0.3f);
                        spawnAsteroid();
                    }
                    asteroidWaves += 2;
                    asteroidCounter = 0;
                    yield return new WaitForSeconds(3.0f);
                }
                else
                {
                    spawnAsteroid();
                }
            }
            else if (respawnProbability > 70 && respawnProbability < 95)
            {
                if (cometCounter == 6)//Comet Rain
                {

                    GameObject warning = Instantiate(warningTextCometPrefab) as GameObject;
                    yield return new WaitForSeconds(1.0f);

                    for (int i = 0; i <= 5; i++)
                    {
                        yield return new WaitForSeconds(0.3f);
                        spawnComet();
                    }
                    cometWaves += 1;
                    cometCounter = 0;
                    yield return new WaitForSeconds(3.0f);
                }
                else
                {
                    spawnComet();
                }
               
            }
            else if (respawnProbability >= 95)
            {
                spawnMeteor();
                yield return new WaitForSeconds(3.0f);
            }


           
           

            

        }
    }
}