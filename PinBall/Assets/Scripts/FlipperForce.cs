using UnityEngine;
using System.Collections;

public class FlipperForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision otherObject)
    {
        Vector3 objectVelocity = otherObject.rigidbody.velocity;
        objectVelocity.x = objectVelocity.x * 2;
        objectVelocity.y = objectVelocity.y * 2;
        objectVelocity.z = objectVelocity.z * 2;
        otherObject.rigidbody.velocity = objectVelocity;
    }
}
