using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    //public GameObject cometaPrefab;
    //public GameObject meteoroPrefab;
    public float respawnTime;
    private Vector2 screenBounds;
    private int wave;
    private float timer;
    private bool random_spawn;

    // Use this for initialization
    void Start()
    {
        random_spawn = false;
        wave = 5;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnAsteroid()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2, 184);
    }


    IEnumerator asteroidWave()
    {

        while (true)
        {

            respawnTime = Random.Range(1.5f, 3);
            yield return new WaitForSeconds(respawnTime);
            spawnAsteroid();

        }
    }
}