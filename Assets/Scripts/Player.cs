using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 playerDirection;
    float playerHorizontalDirection;

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHorizontalDirection = Input.GetAxis("Horizontal");
        playerDirection = new Vector2(playerHorizontalDirection, 0);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = playerDirection * speed ;
    }
}
