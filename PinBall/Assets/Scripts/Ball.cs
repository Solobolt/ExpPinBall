using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public GameObject ball;
    public GameObject spawnLocation;
    private int tiltPower = 5;
    private Camera mainCamera;

    // Use this for initialization
    void Start() {
        mainCamera = Camera.FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update() {
        SetTilt();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Out")
        {
            Destroy(gameObject);
            Instantiate(ball, spawnLocation.transform.position, new Quaternion(0, 0, 0, 0));
        }
    }

    void SetTilt()
    {
        mainCamera.transform.rotation = Quaternion.Euler(50.0f, 0, 0);
        if (Input.GetKey("q"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-tiltPower, 0, 0));
            mainCamera.transform.rotation = Quaternion.Euler(50.0f, 0, -2);
        }

        if (Input.GetKey("e"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(tiltPower, 0, 0));
            mainCamera.transform.rotation = Quaternion.Euler(50.0f, 0, 2);
        }
    }
}
