using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public CollisionCheck collisionCheck;

    public float speed = 2.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);

            spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            spriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.up * -1 * speed * Time.deltaTime);
        }

        if (collisionCheck.GetScore()>=5)
        {
            speed = 9.0f;
        }

        if (collisionCheck.GetScore() == 10)
        {
            speed = 11.0f;
        }

        if (collisionCheck.GetScore() > 15)
        {
            speed = 13.0f;
        }

        if (collisionCheck.GetScore() > 50)
        {
            speed = 16.0f;
        }



        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
