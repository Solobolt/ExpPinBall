using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	bool isActive = false;
	public GameObject ball;
	float firePower;
	public int powerGrowthRate = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey("space"))
		{
			firePower = firePower + (Time.deltaTime * powerGrowthRate);
			if (firePower > 10)
			{
				firePower = 10;
			}
		}


	if (Input.GetKeyUp ("space"))
		{
			if (isActive)
			{
				ball.rigidbody.AddForce (new Vector3(0,0,2000 * (firePower/10)));
			}
			firePower = 0;
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.tag == "Ball")
		{
			isActive = true;
			ball = coll.gameObject;
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if (coll.gameObject.tag == "Ball")
		{
			isActive = false;
			ball = coll.gameObject;
		}
	}
}
