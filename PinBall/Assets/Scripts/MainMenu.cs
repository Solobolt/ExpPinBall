using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void exitGame()
    {
        Application.Quit();
    }

    public void loadScene(int number)
    {
        Application.LoadLevel(number);
    }

}
