using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public GameObject ball;
	public GameObject spawnLocation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.tag == "Out")
		{
			Destroy (gameObject);
			Instantiate (ball,spawnLocation.transform.position,new Quaternion(0,0,0,0));
		}
	}
}
