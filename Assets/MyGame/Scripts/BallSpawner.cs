using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public BallManager BallPrefab;
    private bool spawn = true;

    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 5f;

    public int xMinLeft = -215;
    public int xMaxRight = 333;
    public int ballMinSize = 20;
    public int ballMaxSize = 58;

    public int yPos = 450;

	IEnumerator Start ()
    {
		while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnBall();
        }
	}

    private void SpawnBall()
    {
        transform.position = new Vector3(Random.Range(xMinLeft, xMaxRight), yPos, 0);
        float ballsize = Random.Range(ballMinSize, ballMaxSize);
        BallPrefab.GetComponent<Transform>().localScale = new Vector3(ballsize, ballsize,0);
        Instantiate(BallPrefab, transform.position, transform.rotation);
    }
}
