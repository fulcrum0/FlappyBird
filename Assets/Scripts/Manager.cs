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

    [Header("Settings")]
    int score;


    public void StartTheGame()
    {
        Time.timeScale = 1;
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
        score++;
        scoreText.text = score.ToString();
    }
}