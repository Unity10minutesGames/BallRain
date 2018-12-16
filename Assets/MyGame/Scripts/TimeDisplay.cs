using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeDisplay : MonoBehaviour {

    private GameManager gameManager;
    private Text timerText;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        timerText = FindObjectOfType<Text>();
    }

    public void resetTimerText()
    {
        timerText.text = "0:0";
    }

    private void Update()
    {
        if(timerText != null && gameManager != null)
        {
            timerText.text = gameManager.uitext;
        }
        else
        {
            timerText.text = "X:X";
        }
    }
}
