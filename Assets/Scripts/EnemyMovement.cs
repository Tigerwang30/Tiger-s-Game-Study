using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
        moveSpeed = Random.Range(0.6f, 1.2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(target.position.x - transform.position.x, target.position.y - transform.position.y).normalized * moveSpeed;
    }
}
