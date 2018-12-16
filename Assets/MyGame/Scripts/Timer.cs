using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private static Timer _instance;

    GameManager gameManager;

    private int seconds, minutes;

    private void Awake()
    {
        //SetUpSingelton();
        _instance = this;
    }

    private void SetUpSingelton()
    {
        int numberTimer = FindObjectsOfType<Timer>().Length;
        if (numberTimer > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public static Timer Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Timer>();
                Debug.Log("create Timer instance first time");
            }

            return _instance;
        }
    }

    // Use this for initialization
    void Start () {
        Debug.Log("Timer created in Start");

        ResetTimer();

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

    public string getLastTime()
    {
        return minutes.ToString() + ":" + seconds.ToString();
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
