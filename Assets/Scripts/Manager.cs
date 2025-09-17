using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [Header("Settings")]
    public Bird bird;
    public TextMeshProUGUI scoreText;
    public GameObject startScreen;
    public GameObject playAgain;
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
        playAgain.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}