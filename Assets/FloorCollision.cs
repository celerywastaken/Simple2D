
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    public int Score;
    public CollisionCheck collisionCheck;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Star")
        {
            collisionCheck.UpdateScore(-1);
            collision.gameObject.SetActive(false);
            

        }



    }

        



}
