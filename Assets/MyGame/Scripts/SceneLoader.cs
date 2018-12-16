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
    }

    public void LoadMainGame()
    {
        
        SceneManager.LoadScene("BallRain");
        if (gameManager != null)
        {
            gameManager.SetTimerText("0:0");
            gameManager.EnableTimer(true);
        }
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
