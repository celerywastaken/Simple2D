using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    private int score;
    public Collider2D spawnTrigger;
    public AudioSource audioPlayer;

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
            SetStarPosition(collision.transform);
            //collision.gameObject.SetActive(false);

        }
        
        else

        if (collision.gameObject.tag == "Bonus")
        {
            UpdateScore(10);
            SetStarPosition(collision.transform);
            //collision.gameObject.SetActive(false);
            audioPlayer.Play();

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

    public void SetStarPosition(Transform starTransform)
    {
        float horizontalPosition = Random.Range(spawnTrigger.bounds.min.x, spawnTrigger.bounds.max.x);
        float verticalPosition = Random.Range(spawnTrigger.bounds.min.y, spawnTrigger.bounds.max.y);

        starTransform.position = new Vector2(horizontalPosition, verticalPosition);
        starTransform.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    
}

