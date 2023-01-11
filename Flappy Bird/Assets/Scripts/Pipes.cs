using UnityEngine;

public class Pipes : MonoBehaviour
{
    //public Transform top;
   // public Transform bottom;

    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = -15f;
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        //else if (other.gameObject.CompareTag("Scoring"))
        //{
            //FindObjectOfType<GameManager>().IncreaseScore();
        //}
    }

}
