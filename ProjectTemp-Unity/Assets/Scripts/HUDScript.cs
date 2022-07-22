/****
* Created by: Runran Li
* Date Created: July 6, 2022
*
* Last Edited by:
* Last Edited:
*
* Description: Manages the UI elements for the menu scenes
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libraries for UI components
using TMPro; //libraries for TextMeshPro components

public class HUDScript : MonoBehaviour
{
    //GM Data
    private int level;
    private int totalLevels;
    private int lives;
    private int score;
    private int highscore;

    GameManager gm; //reference to game manager

    [Header("Stats Placement")]
    public TMP_Text levelCountTextbox; //textbox for level count
    public TMP_Text livesTextbox; //textbox for the lives
    public TMP_Text healthTextbox; //textbox for highscore
    public TMP_Text scoreTextbox; //textbox for the score
    public TMP_Text highScoreTextbox; //textbox for highscore
    public TMP_Text collectableCountTextbox; //textbox for amount of collectables
    public TMP_Text TimerTextbox; //textbox for Timer display
    public TMP_Text fastestTimeTextbox; //textbox for the Fastest Time

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GM; //find the game manager
                             //reference to levle info
        level = gm.gameLevelsCount;
        totalLevels = gm.gameLevels.Length;
    }

    // Update is called once per frame
    void Update()
    {
        GetGameStats();
        SetHUD();
    }

    void GetGameStats()
    {
        lives = gm.Lives;
        score = gm.Score;
        highscore = gm.HighScore;
    }//end GetGameStats()

    void SetHUD()
    {
        //if texbox exsists update value
        if (levelCountTextbox)
        {
            levelCountTextbox.text = "Level " + level + "/" + totalLevels;
        }
        if (livesTextbox) { livesTextbox.text = "Lives " + lives; }
        if (scoreTextbox) { scoreTextbox.text = "Score " + score; }
        if (highScoreTextbox) { highScoreTextbox.text = "High Score " + highscore; }
    }//end SetHUD()

}