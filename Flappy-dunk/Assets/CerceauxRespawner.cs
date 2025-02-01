using UnityEngine;

public class CerceauxRespawner : MonoBehaviour
{
    [Header("Déplacement")]
    public float speed = 2f;       // Vitesse du déplacement vers la gauche

    [Header("Repositionnement")]
    public float offScreenX = -10f; // Seuil à gauche pour considérer l'objet hors écran
    public float resetX = 10f;      // Position X à laquelle l'objet réapparaît
    public float minY = -3f;        // Position Y minimale pour le repositionnement
    public float maxY = 3f;         // Position Y maximale pour le repositionnement

    void Update()
    {
        // Déplacement vers la gauche
        transform.position += Vector3.left * speed * Time.deltaTime;

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
}
