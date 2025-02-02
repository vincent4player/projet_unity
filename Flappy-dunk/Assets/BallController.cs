using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public float jumpForce = 12f; // Force du saut plus élevée pour un saut rapide
    public float gravity = 25f;   // Gravité personnalisée pour une chute plus naturelle
    private Rigidbody2D rb;       // Référence au Rigidbody2D du ballon
    public TrailRenderer trail;
    public float normalTrailTime = 0.15f;    // Réduit pour une flamme plus fine
    public float perfectTrailTime = 0.3f;     // Augmenté pour une flamme plus épaisse
    public float normalWidth = 0.2f;          // Largeur normale de la flamme
    public float perfectWidth = 0.4f;         // Largeur pour les tirs parfaits
    public Gradient normalGradient;  // Gradient normal
    public Gradient perfectGradient; // Gradient pour les tirs parfaits
    private AnimationCurve normalCurve;
    private AnimationCurve perfectCurve;
    private bool isComboActive = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Récupère le Rigidbody2D attaché à ce GameObject
        rb.gravityScale = 0f; // Désactive la gravité Unity par défaut
        
        // Crée les courbes de largeur
        normalCurve = new AnimationCurve();
        normalCurve.AddKey(0, 0.5f);
        normalCurve.AddKey(0.5f, 0.2f);
        normalCurve.AddKey(1, 0);

        perfectCurve = new AnimationCurve();
        perfectCurve.AddKey(0, 0.7f);    // Plus large pour l'effet perfect
        perfectCurve.AddKey(0.5f, 0.3f);
        perfectCurve.AddKey(1, 0);

        if (trail != null)
        {
            trail.widthCurve = normalCurve;
            trail.time = normalTrailTime;
            trail.colorGradient = normalGradient;
            trail.enabled = false; // Désactive la traînée au démarrage
        }
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

        // N'ajuste la rotation que si le combo est actif
        if (trail != null && isComboActive)
        {
            if (velocityY > 0)
            {
                // Flamme vers le bas quand la balle monte
                trail.transform.rotation = Quaternion.Euler(0, 0, -180);
            }
            else
            {
                // Flamme vers le haut quand la balle descend
                trail.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }

    void Jump()
    {
        rb.linearVelocity = Vector2.up * jumpForce; // Saut instantané vers le haut
    }

    public void ActivatePerfectEffect()
    {
        if (trail != null)
        {
            isComboActive = true;
            trail.enabled = true;
            trail.time = perfectTrailTime;
            trail.colorGradient = perfectGradient;
            trail.widthCurve = perfectCurve;
            StartCoroutine(ResetTrailEffect());
        }
    }

    public void DeactivateCombo()
    {
        if (trail != null)
        {
            isComboActive = false;
            trail.enabled = false;
        }
    }

    IEnumerator ResetTrailEffect()
    {
        yield return new WaitForSeconds(1f);
        if (!isComboActive) // Ne désactive que si le combo n'est plus actif
        {
            trail.enabled = false;
        }
        trail.time = normalTrailTime;
        trail.colorGradient = normalGradient;
        trail.widthCurve = normalCurve;
    }
}
