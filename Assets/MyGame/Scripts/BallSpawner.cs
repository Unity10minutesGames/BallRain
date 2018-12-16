using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public BallManager BallPrefab;
    private bool spawn = true;

    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 5f;

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
        transform.position = new Vector3(Random.Range(-215, 333), 450, 0);
        float ballsize = Random.Range(20, 58);
        BallPrefab.GetComponent<Transform>().localScale = new Vector3(ballsize, ballsize,0);
        Instantiate(BallPrefab, transform.position, transform.rotation);
    }
}
