using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    GameManager gameManager;

    private void Start()
    {
        
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));   
        if(gameManager == null)
        {
            Debug.Log("game manager == null");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(gameManager!= null)
            {
                gameManager.SetPlayerHit(true);
            }
            
        }
        else if (collision.tag == "Collider")
        {
            Destroy(gameObject);
        }
        
    }

}
