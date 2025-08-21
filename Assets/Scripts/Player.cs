using Unity.Burst.Intrinsics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public float jumpForce = 8f;
    public Vector2 playerDirection;
    float moveX;
    private Rigidbody2D rb;

    bool jumpRequested;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(moveX, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpRequested = true;    
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);
        if (jumpRequested)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpRequested = false;   
        }
    }




}
