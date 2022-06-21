using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI text;
    [SerializeField] float currentTime;

    private void Awake()
    {
        currentTime *= 60;
    }

    void Update()
    {
        UpdateTime();
    }
    void UpdateTime()
    {
        currentTime = currentTime - Time.deltaTime;

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        text.text = "Time: " + time.ToString(@"mm\:ss");
        if (currentTime <= 0)
        {
            ResetScene();
        }
    }
    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
