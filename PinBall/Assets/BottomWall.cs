using UnityEngine;
using System.Collections;

public class BottomWall : MonoBehaviour {

	GameObject ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.FindGameObjectWithTag ("Ball");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onCollisionEnter(Collision col)
	{
		print ("Hit");
	}
}
