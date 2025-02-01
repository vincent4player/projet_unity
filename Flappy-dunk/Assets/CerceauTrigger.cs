using UnityEngine;

public class CerceauTrigger : MonoBehaviour
{
    public ScoreManager scoreManager; // Référence au gestionnaire de score

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ballon")) // Vérifie si c'est bien le ballon
        {
            scoreManager.AddScore(1); // Ajoute 1 point
        }
    }
}
