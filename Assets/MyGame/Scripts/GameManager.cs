using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public string startText = "0:0";
    public string uitext;


    private bool playerHit;
    private bool startTimer;

    private Text timerText;

    Timer timer;

    SceneLoader sceneLoader;

    private void Awake()
    {
        SetUpSingelton();
    }

    private void SetUpSingelton()
    {
        int numberGameManager = FindObjectsOfType<GameManager>().Length;
        if (numberGameManager > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        
    }

    // Use this for initialization
    void Start () {
        timerText = FindObjectOfType<Text>();
        timer = Timer.Instance;
        sceneLoader = FindObjectOfType<SceneLoader>();
        playerHit = false;
        startTimer = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (startTimer)
        {
            if(timer != null)
            {
                timer.StartTimer();
                startTimer = false;
            }
            
        }

        if (playerHit)
        {
            playerHit = !playerHit;
            timer.StopTimer();
            sceneLoader.LoadGameOver();
        }

        
	}

    public void SetPlayerHit(bool hit)
    {
        playerHit = hit;
    }

    public void EnableTimer(bool timerOn)
    {
        startTimer = timerOn;
    }

    public void SetTimerText(string txt)
    {
        uitext = txt;
    }
}
