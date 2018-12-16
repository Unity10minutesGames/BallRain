using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void LoadWelcome()
    {
        SceneManager.LoadScene(0);
        if(gameManager != null)
        {
            gameManager.ResetTimerText();
        }
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene("BallRain");
        if (gameManager != null)
        {
            gameManager.EnableTimer(true);
        }
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
