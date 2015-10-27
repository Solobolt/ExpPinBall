using UnityEngine;
using System.Collections;

public class OneWayDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherObject)
	{
		if(otherObject.gameObject.tag == "Ball")
		{
			Rigidbody ballRigidBody = otherObject.gameObject.GetComponent<Rigidbody>();
			float xVelocity = ballRigidBody.velocity.x;
			float yVelocity = ballRigidBody.velocity.y;
			float zVelocity = ballRigidBody.velocity.z;

			if(xVelocity > 0)
			{
				xVelocity = xVelocity * (-1);
				otherObject.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(xVelocity,yVelocity,zVelocity);
			}
		}

	}
}
