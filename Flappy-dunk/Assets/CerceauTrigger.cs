using UnityEngine;

public class CerceauTrigger : MonoBehaviour
{
    public ScoreManager scoreManager; // Référence au gestionnaire de score
    public float perfectZoneWidth = 0.5f; // Largeur de la zone parfaite au centre
    public ParticleSystem perfectEffect; // Ajouter un effet de particules
    private CerceauxRespawner cerceauxRespawner;
    private BallController ballController;

    void Start()
    {
        cerceauxRespawner = GetComponent<CerceauxRespawner>();
        if (cerceauxRespawner == null)
        {
            cerceauxRespawner = GetComponentInParent<CerceauxRespawner>();
        }

        // Trouve la référence au BallController
        ballController = FindObjectOfType<BallController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ballon"))
        {
            // Calcule la distance horizontale entre le ballon et le centre du cerceau
            float distanceFromCenter = Mathf.Abs(other.transform.position.x - transform.position.x);
            bool isPerfect = distanceFromCenter < perfectZoneWidth;

            if (isPerfect)
            {
                scoreManager.AddScore(2, true); // Tir parfait
                if (perfectEffect != null)
                    perfectEffect.Play(); // Jouer l'effet pour un tir parfait
                if (cerceauxRespawner != null)
                    cerceauxRespawner.IncreaseSpeed();
                if (ballController != null)
                    ballController.ActivatePerfectEffect();
                Debug.Log("Perfect! +2 points");
            }
            else
            {
                scoreManager.AddScore(1, false); // Tir normal
                Debug.Log("Nice! +1 point");
            }
        }
    }
}
