using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastScore : MonoBehaviour
{
    public Text scoreText;
    public static int scorePoints;

    // Start is called before the first frame update
    void Start()
    {
        //scorePoints = FindObjectOfType<Score>().scorePoints;
        scorePoints = Score.scorePoints;
        scoreText.text = "Your Score: " + scorePoints.ToString("0");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
