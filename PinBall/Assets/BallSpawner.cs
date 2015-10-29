using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    private GameManager gameManager;

    public GameObject ball;



	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        spawnBall();
	}

    void spawnBall()
    {
        if (Input.GetKeyDown("r") && gameManager.numPinBalls < 3)
        {
            Instantiate(ball, this.transform.position, new Quaternion(0, 0, 0, 0));
        }
    }
}
