using UnityEngine;

public class BallController : MonoBehaviour
{
    public float jumpForce = 6f; // Force du saut
    private Rigidbody2D rb;       // Référence au Rigidbody2D du ballon

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Récupère le Rigidbody2D attaché à ce GameObject
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(); // Appelle la méthode Jump() lorsque l'on appuie sur Espace
        }
    }

    void Jump()
    {
        rb.linearVelocity = Vector2.zero; // Réinitialise la vitesse du ballon
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // Applique une impulsion vers le haut
    }
}
