using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public GameObject ball;
    public GameObject spawnLocation;
    private int tiltPower = 5;
    private GameObject mainCamera;
    private Transform myTransform;
    private GameManager gameManager;
    private AudioController audioController;

    public GameObject DeathExplotion;

    // Use this for initialization
    void Start() {
        myTransform = this.transform;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        spawnLocation = GameObject.FindGameObjectWithTag("Spawn");
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        audioController = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioController>();

        gameManager.numPinBalls++;
    }

    // Update is called once per frame
    void Update() {
        SetTilt();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Out")
        {
            gameManager.removeLife();
            
            if(gameManager.numPinBalls < 3)
            {
                Instantiate(ball, spawnLocation.transform.position, new Quaternion(0, 0, 0, 0));
            }
            else
            { if (gameManager.uiLives == 1)
                {
                    print("GAMEOVER");
                }

            }
            Instantiate(DeathExplotion,myTransform.position,myTransform.rotation);
            Destroy(gameObject);
            audioController.playBigExplotion();
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
