using UnityEngine;

public class BallController : MonoBehaviour
{
    public float jumpForce = 12f; // Force du saut plus élevée pour un saut rapide
    public float gravity = 25f;   // Gravité personnalisée pour une chute plus naturelle
    private Rigidbody2D rb;       // Référence au Rigidbody2D du ballon

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Récupère le Rigidbody2D attaché à ce GameObject
        rb.gravityScale = 0f; // Désactive la gravité Unity par défaut
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(); // Appelle la méthode Jump() lorsque l'on appuie sur Espace
        }

        // Applique notre propre gravité
        float velocityY = rb.linearVelocity.y - (gravity * Time.deltaTime);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, velocityY);
    }

    void Jump()
    {
        rb.linearVelocity = Vector2.up * jumpForce; // Saut instantané vers le haut
    }
}
