using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private static Timer _instance;
    private GameManager gameManager;
    private int seconds, minutes;

    private void Awake()
    {
        _instance = this;
        ResetTimer();
    }

    public static Timer Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Timer>();
            }

            return _instance;
        }
    }

    public void ResetTimer()
    {
        seconds = 0;
        minutes = 0;
    }

    public void StartTimer()
    {
        ResetTimer();
        gameManager = GetComponent<GameManager>();
        StartCoroutine(RunTimer());
    }

    public void StopTimer()
    {
        StopAllCoroutines();
    }


    private IEnumerator RunTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            seconds++;

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            gameManager.SetTimerText(minutes.ToString() + ":" + seconds.ToString());
        }
        
    }
}
