using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
    private const string AXISHORIZONTAL = "Horizontal";
    private const string AXISVERTICAL = "Vertical";


    public float moveSpeed = 10f;
    public float padding = 10f;
    public int health = 20; 

    private float xMin, xMax;

    // Use this for initialization
    void Start () {
        SetupMoveBounderies();
    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    private void SetupMoveBounderies()
    {

        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;

    }

    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed; //frame rate independent
        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);

        transform.position = new Vector2(newXPos, transform.position.y);
    }

    public int GetHealth()
    {
        return health;
    }
}
