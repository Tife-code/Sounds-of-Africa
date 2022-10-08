using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int scorePoints;
    public int scoree = 0;

    public void ScoreUpdate( int score)
    {
        scoree += score;
        scorePoints = scoree;
        scoreText.text = scorePoints.ToString("0");
    }
}
