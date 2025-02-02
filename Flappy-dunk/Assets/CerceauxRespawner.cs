using UnityEngine;

public class CerceauxRespawner : MonoBehaviour
{
    [Header("Déplacement")]
    public float baseSpeed = 2f;        // Vitesse de base
    public float maxSpeed = 5f;         // Vitesse maximale
    public float speedIncrease = 0.2f;  // Augmentation de vitesse par perfect
    private float currentSpeed;         // Vitesse actuelle

    [Header("Repositionnement")]
    public float offScreenX = -10f; // Seuil à gauche pour considérer l'objet hors écran
    public float resetX = 10f;      // Position X à laquelle l'objet réapparaît
    public float minY = -3f;        // Position Y minimale pour le repositionnement
    public float maxY = 3f;         // Position Y maximale pour le repositionnement

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        // Déplacement vers la gauche
        transform.position += Vector3.left * currentSpeed * Time.deltaTime;

        // Si le cerceau est hors écran, le repositionner
        if (transform.position.x < offScreenX)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        float newY = Random.Range(minY, maxY);
        transform.position = new Vector3(resetX, newY, transform.position.z);
    }

    public void IncreaseSpeed()
    {
        currentSpeed = Mathf.Min(currentSpeed + speedIncrease, maxSpeed);
        Debug.Log($"Nouvelle vitesse: {currentSpeed}");
    }
}
