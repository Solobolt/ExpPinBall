using UnityEngine;
using System.Collections;

public class Kicker : MonoBehaviour {

    private GameManager gameManager;
    private AudioController audioController;

    private Transform myTransform;
    private int maxVelocity = 30;

    // Use this for initialization
    void Start()
    {
        myTransform = this.transform;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        audioController = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Handles collitions
    void OnCollisionEnter(Collision otherObject)
    {
        //Adds 10 points to the players score
        gameManager.addScore(10);

        //doubles the pinballs velocity
        //NOTE: a bouncing material on the gameobject removes any need for changing direction
        Vector3 objectVelocity = otherObject.rigidbody.velocity;
        objectVelocity.x = objectVelocity.x * 5f;
        objectVelocity.y = objectVelocity.y * 5f;
        objectVelocity.z = objectVelocity.z * 5f;

        //velovity Limit positive side
        if (objectVelocity.x > maxVelocity)
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

        //Sets the gameobjects velocity 
        otherObject.rigidbody.velocity = objectVelocity;

        audioController.playBumperExplotion();
    }
}
