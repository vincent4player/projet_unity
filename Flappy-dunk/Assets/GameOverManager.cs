using UnityEngine;
using TMPro; // Ajout de l'import pour TextMeshPro
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;    // Référence au panel Game Over
    public TMP_Text finalScoreText;    // Changé de Text à TMP_Text
    public ScoreManager scoreManager;    // Référence au ScoreManager

    void Start()
    {
        if (finalScoreText == null)
            Debug.LogError("FinalScoreText non assigné!");
        if (scoreManager == null)
            Debug.LogError("ScoreManager non assigné!");
        
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowGameOver()
    {
        if (finalScoreText != null && scoreManager != null)
        {
            int currentScore = scoreManager.GetScore();
            Debug.Log("Score final : " + currentScore); // Pour déboguer
            finalScoreText.text = "Score Final: " + currentScore;
        }
        else
        {
            Debug.LogError("Références manquantes dans GameOverManager!");
        }

        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
} 