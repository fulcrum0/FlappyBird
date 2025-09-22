using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [Header("References")]
    public Bird bird;
    public TextMeshProUGUI scoreText;
    public GameObject startScreen;
    public GameObject gameOver;
    [SerializeField] TextMeshProUGUI highScoreText;

    [Header("Settings")]
    int score;
    int highScore;

    void Start()
    {
        scoreText.gameObject.SetActive(true);
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore;
    }

    public void StartTheGame()
    {
        Time.timeScale = 1;
        score = 0;
        scoreText.text = score.ToString();
        scoreText.gameObject.SetActive(true);
        bird.isAlive = true;
        startScreen.SetActive(false);
    }

    public void PlayAgain()
    {
        startScreen.SetActive(true);
        gameOver.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void UpdateScore()
    {
        score += 1;
        scoreText.text = score.ToString();

        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "High Score: " + highScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
