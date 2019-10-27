using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public int wave;
    public float respawnTime;

    //public GameObject cometaPrefab;
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
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2, 184);
        asteroidCounter = asteroidCounter + 1;
        Debug.Log(asteroidCounter);
    }


    IEnumerator asteroidWave()
    {

        while (true)
        {

            respawnTime = Random.Range(1.5f, 3);
            yield return new WaitForSeconds(respawnTime);
            spawnAsteroid();

            if (asteroidCounter == 20)
            {
                for (int i = 0; i <= wave; i++)
                {
                    yield return new WaitForSeconds(0.3f);
                    spawnAsteroid();
                }
                wave = wave + 2;
                asteroidCounter = 0;
            }


        }
    }
}