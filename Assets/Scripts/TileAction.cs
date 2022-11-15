using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TileAction : MonoBehaviour
{
    public SpriteRenderer changeColor;
    public int scoreValue = 1;
    private Rigidbody2D tileRb;
    public float speed = 500f;
    public AudioClip touchSound;
    private int i = 1;
    private bool isClick = false;

    public void Update()
    {
        tileRb = GetComponent<Rigidbody2D>();
        tileRb.velocity = new Vector3(0, -speed * Time.deltaTime, 0);
        if (FindObjectOfType<Score>().scoree > i * 10){
            speed += 100;
            i++;
        }

    }

    private void OnMouseOver()
    {
        if(isClick == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                changeColor.color = Color.yellow;
                FindObjectOfType<Score>().ScoreUpdate(scoreValue);
                //touchSound.p
                isClick = true;
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(changeColor.color == Color.yellow)
        {
            //Debug.Log("you are fine");
        }
        else if (collision.gameObject.tag == "border")
        {
            //Debug.Log("Game over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
