using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed;
    private Rigidbody2D rb; // Para jogos 2D, use Rigidbody para 3D

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtenha a refer ncia ao Rigidbody2D
        // Se for 3D, use: rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() // Use FixedUpdate para opera  es de f sica
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * runSpeed, rb.linearVelocity.y); // Mant m a velocidade vertical existente
        rb.linearVelocity = movement;
    }
}
