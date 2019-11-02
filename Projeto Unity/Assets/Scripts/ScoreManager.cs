using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float scoreCount;
    public int pointsPerSecond = 1;
<<<<<<< Updated upstream
    private TextMeshProUGUI textObject;
=======
    private TextMeshPro textObject;
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        textObject = GetComponent<TextMeshProUGUI>();
=======
        textObject = GetComponent<TextMeshPro>();
>>>>>>> Stashed changes
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textObject.text = "Score: " + Mathf.Round(scoreCount);
        scoreCount += pointsPerSecond * Time.deltaTime;
    }
}
