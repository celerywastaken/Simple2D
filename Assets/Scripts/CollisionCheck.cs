using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    private int score;



    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Debug.Log("Score:" + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Star")
        {
            UpdateScore(1);
            
            collision.gameObject.SetActive(false);

        }
        
        else

        if (collision.gameObject.tag == "Bonus")
        {
            UpdateScore(10);

            collision.gameObject.SetActive(false);

        }

    }
    public void UpdateScore(int scoreValue)
    {
        score += scoreValue;

        if (score <= 0)
        {
            score = 0;
        }
        Debug.Log("Score:" + score);
    }
    public int GetScore()
    {
        return score;
    }
      
   
}

