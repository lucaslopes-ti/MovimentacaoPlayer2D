using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed;
    private Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate() 
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * runSpeed, rb.linearVelocity.y);
        rb.linearVelocity = movement;
    }
}
