using UnityEngine;
using System.Collections;

public class RightFlipper : MonoBehaviour {

	private float flipSpeed = 9f;
	private string controlButton = "d";
	
	
	private Vector3 targetAngle = new Vector3(0f, 20.0f, 0f);
	private Vector3 startingAngle = new Vector3 (0f, -20.0f,0f);
	private Vector3 currentAngle;

    // Use this for initialization
    void Start () {
		currentAngle = transform.eulerAngles;
	}

	// Update is called once per frame
	void Update () {
        // Rotates the object

        if (Input.GetKey(controlButton))
		{
			Flip ();
		}
		else 
		{
			FlipReturn();
		}
	}
	
	void Flip()
	{
		currentAngle = new Vector3(
			Mathf.LerpAngle(currentAngle.x, targetAngle.x, Time.deltaTime * flipSpeed),
			Mathf.LerpAngle(currentAngle.y, targetAngle.y, Time.deltaTime * flipSpeed),
			Mathf.LerpAngle(currentAngle.z, targetAngle.z, Time.deltaTime * flipSpeed));
		
		transform.eulerAngles = currentAngle;
	}
	
	void FlipReturn()
	{
		currentAngle = new Vector3(
			Mathf.LerpAngle(currentAngle.x, startingAngle.x, Time.deltaTime * flipSpeed * 2),
			Mathf.LerpAngle(currentAngle.y, startingAngle.y, Time.deltaTime * flipSpeed * 2),
			Mathf.LerpAngle(currentAngle.z, startingAngle.z, Time.deltaTime * flipSpeed * 2));
		
		transform.eulerAngles = currentAngle;
	}
}
