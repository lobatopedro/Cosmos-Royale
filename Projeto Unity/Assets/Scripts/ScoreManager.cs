using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float scoreCount;
    public float pointsPerSecond = 1;
    private TextMesh textObject;

    // Start is called before the first frame update
    void Start()
    {
        textObject = GameObject.Find("Score").GetComponent<TextMesh>();
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        scoreCount += pointsPerSecond + Time.deltaTime;
        textObject.text = "Score: " + Mathf.Round(scoreCount); 
    }
}
