using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text comboText;
    private int score = 0;
    private int comboMultiplier = 1;
    private int perfectsInARow = 0;
    private BallController ballController;

    void Start()
    {
        UpdateUI();
        ballController = FindObjectOfType<BallController>();
    }

    public void AddScore(int points, bool isPerfect)
    {
        if (isPerfect)
        {
            perfectsInARow++;
            comboMultiplier = Mathf.Min(perfectsInARow, 4); // Max x4
        }
        else
        {
            perfectsInARow = 0;
            comboMultiplier = 1;
            if (ballController != null)
            {
                ballController.DeactivateCombo();
            }
        }

        score += points * comboMultiplier;
        UpdateUI();
    }

    public int GetScore() // Nouvelle méthode pour accéder au score
    {
        return score;
    }

    void UpdateUI()
    {
        scoreText.text = $"Score: {score}";
        if (comboMultiplier > 1)
            comboText.text = $"x{comboMultiplier} COMBO!";
        else
            comboText.text = "";
    }
}
