using UnityEngine;
using TMPro; // Ajout de l'import pour TextMeshPro
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;    // Référence au panel Game Over
    public TMP_Text finalScoreText;    // Changé de Text à TMP_Text
    public TMP_Text bestScoreText;    // Nouveau texte pour le meilleur score
    public ScoreManager scoreManager;    // Référence au ScoreManager
    private AudioManager audioManager;

    void Start()
    {
        if (finalScoreText == null || bestScoreText == null)
            Debug.LogError("Textes non assignés!");
        if (scoreManager == null)
            Debug.LogError("ScoreManager non assigné!");
        
        audioManager = FindObjectOfType<AudioManager>();
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowGameOver()
    {
        if (finalScoreText != null && scoreManager != null)
        {
            int currentScore = scoreManager.GetScore();
            
            // Vérifie et met à jour le meilleur score
            int bestScore = PlayerPrefs.GetInt("BestScore", 0);
            if (currentScore > bestScore)
            {
                bestScore = currentScore;
                PlayerPrefs.SetInt("BestScore", bestScore);
                PlayerPrefs.Save();
            }

            // Affiche les scores
            finalScoreText.text = $"Score Final: {currentScore}";
            bestScoreText.text = $"Meilleur Score: {bestScore}";

            // Joue le son de game over et arrête la musique
            if (audioManager != null)
            {
                audioManager.StopMusic();
                audioManager.PlayGameOverSound();
            }
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