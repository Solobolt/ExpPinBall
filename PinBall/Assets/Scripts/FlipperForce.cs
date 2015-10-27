using UnityEngine;
using System.Collections;

public class FlipperForce : MonoBehaviour {

    Vector3 baseRotation;
    public string controlButton = "d";


    private float hitPower = 5f;
    private float bouncePower = 1.5f;

	private bool movingPaddle;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	if (this.gameObject.GetComponentInParent<RightFlipper> () != null) {
			movingPaddle = this.gameObject.GetComponentInParent<RightFlipper> ().isMoving;
		} else {
			if (this.gameObject.GetComponentInParent<LeftFlipper> ()!= null)
			{
				movingPaddle = this.gameObject.GetComponentInParent<LeftFlipper> ().isMoving;
			}
		}
	}

    void OnCollisionEnter(Collision otherObject)
    {
		if (movingPaddle)
		{
			Vector3 objectVelocity = otherObject.rigidbody.velocity;
			objectVelocity.x = objectVelocity.x * bouncePower;
			objectVelocity.y = objectVelocity.y * bouncePower;
			objectVelocity.z = objectVelocity.z * bouncePower;
			otherObject.rigidbody.velocity = objectVelocity;
			
			if (Input.GetKey(controlButton))
			{
				objectVelocity.z += hitPower;
				otherObject.rigidbody.velocity = objectVelocity;
			}
		}
    }
    void OnCollisionStay(Collision otherObject)
    {
        if (Input.GetKey (controlButton) && movingPaddle)
        {
            Vector3 objectVelocity = otherObject.rigidbody.velocity;
            objectVelocity.z += hitPower;
            otherObject.rigidbody.velocity = objectVelocity;
        }
    }
}
