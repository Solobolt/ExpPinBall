using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public GameObject ball;
	public GameObject spawnLocation;
	private int tiltPower = 200;
	private Camera mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.FindObjectOfType <Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown ("q"))
		{
			rigidbody.AddForce (new Vector3(-tiltPower,0,0));
		}

		if (Input.GetKeyDown ("e"))
		{
			rigidbody.AddForce (new Vector3(tiltPower,0,0));
		}
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
