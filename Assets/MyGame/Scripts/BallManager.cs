using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    private const string TAGPLAYER = "Player";
    private const string TAGCOLLIDER = "Collider";

    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == TAGPLAYER)
        {
            if(gameManager!= null)
            {
                gameManager.SetPlayerHit(true);
            }
        }
        else if (collision.tag == TAGCOLLIDER)
        {
            Destroy(gameObject);
        }
        
    }

}
