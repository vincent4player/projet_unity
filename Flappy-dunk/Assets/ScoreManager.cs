using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText; // Changé de Text à TMP_Text
    private int score = 0;

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    public int GetScore() // Nouvelle méthode pour accéder au score
    {
        return score;
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
