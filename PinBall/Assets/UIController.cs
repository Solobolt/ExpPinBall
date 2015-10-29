using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

    public void LoadMainMenu()
    {
        Application.LoadLevel(0);
    }

    public void RestartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
