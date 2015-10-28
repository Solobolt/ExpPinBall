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


	//For Set timeScale

	public float setTimeScale = 1.5f;

    //Links to the UI
    public Text uiScoreText;
    public Text uiLivesText;

    // Use this for initialization
    void Start() {
        Time.timeScale = setTimeScale;
    }

    // Update is called once per frame
    void Update() {
        UIvalues();
        UpdateUI();
    }

    //Adds a give value to the score
    public void addScore(int value)
    {
        score += value;
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
        uiLivesText.text = "Lives: " + uiLives.ToString();
        uiScoreText.text = "Score: " + uiScore.ToString();
    }
}
