using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    private GameManager gameManager;
    private Text timerText;

    private string missingTime = "X:X";

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        timerText = FindObjectOfType<Text>();
    }

    public void resetTimerText()
    {
        timerText.text = gameManager.startText;
    }

    private void Update()
    {
        if(timerText != null && gameManager != null)
        {
            timerText.text = gameManager.uitext;
        }
        else
        {
            timerText.text = missingTime;
        }
    }
}
