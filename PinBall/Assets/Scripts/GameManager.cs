using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    //for keeping track of the player score
    private int score = 0;
    public int uiScore;

    //for keeping track of player lives
    private int lives = 3;
    public int uiLives;

    //Hold number of pinballs in play
    public int numPinBalls = 0;

    //Holds pause menu items
    bool isPaused = false;
    public Canvas pauseScreen;

    //Hold GameOver SCreen 
    public Canvas gameOverScreen;


	//For Set timeScale
	public float setTimeScale = 1.5f;

    //Links to the UI
    public Text uiScoreText;
    public Text uiLivesText;

    // Use this for initialization
    void Start() {
        Time.timeScale = setTimeScale;
        pauseScreen.enabled = false;
        gameOverScreen.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        UIvalues();
        UpdateUI();
        PauseMenuCheck();
        checkGameOver();
    }

    //CHecks to see if the player has lots all of thier lives
    void checkGameOver()
    {
        if (numPinBalls == 3 && lives == 0)
        {
            gameOverScreen.enabled = true;
        }
    }

    //Adds a give value to the score
    public void addScore(int value)
    {
        score += value * numPinBalls;
    }

    //Removes a life
    public void removeLife()
    {
        lives --;
    }

    //Changes the editable values to equal the set values
    void UIvalues()
    {
        uiScore = score;
        uiLives = lives;
    }

    //Update UI
    void UpdateUI()
    {
        uiLivesText.text = "Pin Balls Left: " + (3 - numPinBalls).ToString();
        uiScoreText.text = "Score: " + uiScore.ToString();
    }

    //Pause Menu Controll
    void PauseMenuCheck()
    {
        if (Input.GetKeyDown("escape"))
        {
            print("Pause");

            if (isPaused == false)
            {
                Time.timeScale = 0;
                isPaused = true;
                pauseScreen.enabled = true;
            }
            else
            {
                Time.timeScale = setTimeScale;
                isPaused = false;
                pauseScreen.enabled = false;
            }
        }

    }
}
