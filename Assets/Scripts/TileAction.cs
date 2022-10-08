using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TileAction : MonoBehaviour
{
    public SpriteRenderer changeColor;
    public int scoreValue = 1;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            changeColor.color = Color.yellow;
            FindObjectOfType<Score>().ScoreUpdate(scoreValue);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(changeColor.color == Color.yellow)
        {
            Debug.Log("you are fine");
        }
        else if (collision.gameObject.tag == "border")
        {
            //Debug.Log("Game over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
