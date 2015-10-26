using UnityEngine;
using System.Collections;

public class BottomWall : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onCollisionEnter(Collision col)
	{
		print ("Hit");
	}
}
