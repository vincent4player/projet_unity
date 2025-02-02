using UnityEngine;
using UnityEngine.SceneManagement;  // Nécessaire pour recharger la scène

public class BallCollision : MonoBehaviour
{
    public GameOverManager gameOverManager; // Référence au GameOverManager

    // Cette fonction est appelée lorsqu'une collision est détectée
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si la balle touche un objet tagué "Border"
        if(collision.gameObject.CompareTag("Border"))
        {
            gameOverManager.ShowGameOver();
        }
    }
}
