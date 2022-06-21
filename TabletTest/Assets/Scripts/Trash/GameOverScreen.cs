using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject game;

    public void GameOver(float score)
    {
        gameObject.SetActive(true);
        game.SetActive(false);
        scoreText.text = score.ToString();
    }

   public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
