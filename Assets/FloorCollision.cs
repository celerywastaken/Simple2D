
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    public int Score;
    public CollisionCheck collisionCheck;
    public Collider2D spawnTrigger;
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
        Debug.Log("Collided with something");
        if (collision.gameObject.tag == "Star")
        {
            collisionCheck.UpdateScore(-1);
            //collision.gameObject.SetActive(false);
            SetStarPosition(collision.transform);
        }
        if (collision.gameObject.tag == "Bonus")
        {
            collisionCheck.UpdateScore(-5);
            //collision.gameObject.SetActive(false);
            SetStarPosition(collision.transform);
        }



    }

    public void SetStarPosition(Transform starTransform)
    {
        float horizontalPosition = Random.Range(spawnTrigger.bounds.min.x, spawnTrigger.bounds.max.x);
        float verticalPosition = Random.Range(spawnTrigger.bounds.min.y, spawnTrigger.bounds.max.y);

        starTransform.position = new Vector2(horizontalPosition, verticalPosition);
        starTransform.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }



}
