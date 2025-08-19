using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;

    public float jumpForce = 2f;
    public Vector2 playerDirection;
    float playerHorizontalDirection;
    float playerVerticalDirection;

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        playerHorizontalDirection = Input.GetAxis("Horizontal");
        playerVerticalDirection = Input.GetAxis("Vertical");
        playerDirection = new Vector2(playerHorizontalDirection, 0);

       
    }
    void FixedUpdate()
    {
        rb.linearVelocity = playerDirection * speed ;
         if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            Debug.Log("Pula");
        }
        
    }
        void Jump()
        {
            Vector2 v = rb.linearVelocity;
            v.y = jumpForce;
            rb.linearVelocity = v;
        }
    }
