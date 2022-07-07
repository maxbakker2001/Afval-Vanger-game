using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject game;
    public GameObject Startscreen;
    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void GameOver(float score)
    {
        gameObject.SetActive(true);
        game.SetActive(false);
        scoreText.text = score.ToString();
        Time.timeScale = 0;
    }

    public void StartGame()
    { 
        Startscreen.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1;
    }

   public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
