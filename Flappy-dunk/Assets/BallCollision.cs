using UnityEngine;
using UnityEngine.SceneManagement;  // Nécessaire pour recharger la scène

public class BallCollision : MonoBehaviour
{
    // Cette fonction est appelée lorsqu'une collision est détectée
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si la balle touche un objet tagué "Border"
        if(collision.gameObject.CompareTag("Border"))
        {
            Debug.Log("Game Over !");
            // Ici, on peut afficher une UI Game Over ou recharger la scène.
            // Par exemple, pour recharger la scène actuelle :
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
