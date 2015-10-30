using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    private AudioController audioController;

    public GameObject explotionEffect;

	public GameObject ball;
	float firePower;
    private float maxLaunchPower = 10.0f;

    private Transform myTransform;

	public int powerGrowthRate = 10;
	// Use this for initialization
	void Start () {
        audioController = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioController>();
        myTransform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey("space"))
		{
			firePower = firePower + (Time.deltaTime * powerGrowthRate);
			if (firePower > maxLaunchPower)
			{
				firePower = maxLaunchPower;
			}
		}


	if (Input.GetKeyUp ("space"))
		{
            force();
            Instantiate(explotionEffect,myTransform.position,myTransform.rotation);
            audioController.playBallLauncherSound();
		}
	}


    public float radius = 5.0F;


    void force()
    {
        Vector3 myPosition = transform.position;
        Collider[] markedObject = Physics.OverlapSphere(myPosition, radius);
        foreach (Collider otherObject in markedObject)
        {
            Rigidbody rb = otherObject.GetComponent<Rigidbody>();
            if (otherObject.tag == "Ball")
            {
                if (rb != null)
                    rb.velocity = new Vector3(0,0, firePower*5);
            }
            else
            {
                if (rb != null)
                    rb.AddExplosionForce(firePower, myPosition, radius, 3.0F);
            }                
        }
    }
}
