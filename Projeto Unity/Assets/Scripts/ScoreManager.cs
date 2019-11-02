using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float scoreCount;
    public int pointsPerSecond = 1;
    private TextMeshPro textObject;

    // Start is called before the first frame update
    void Start()
    {
        textObject = GetComponent<TextMeshPro>();
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textObject.text = "Score: " + Mathf.Round(scoreCount);
        scoreCount += pointsPerSecond * Time.deltaTime;
    }
}
