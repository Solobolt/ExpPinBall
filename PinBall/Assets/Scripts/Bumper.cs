using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

    private int maxVelocity = 30;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision otherObject)
    {
        Vector3 objectVelocity = otherObject.rigidbody.velocity;
        objectVelocity.x = objectVelocity.x * 2f;
        objectVelocity.y = objectVelocity.y * 2f;
        objectVelocity.z = objectVelocity.z * 2f;
        
        //velovity Limit positive side
        if(objectVelocity.x > maxVelocity)
        {
            objectVelocity.x = maxVelocity;
        }
        if (objectVelocity.y > maxVelocity)
        {
            objectVelocity.y = maxVelocity;
        }
        if (objectVelocity.z > maxVelocity)
        {
            objectVelocity.z = maxVelocity;
        }
        //velocity Limit negative side
        if (objectVelocity.x < -maxVelocity)
        {
            objectVelocity.x = -maxVelocity;
        }
        if (objectVelocity.y < -maxVelocity)
        {
            objectVelocity.y = -maxVelocity;
        }
        if (objectVelocity.z < -maxVelocity)
        {
            objectVelocity.z = -maxVelocity;
        }

        otherObject.rigidbody.velocity = objectVelocity;
        print(objectVelocity);
    }
}
