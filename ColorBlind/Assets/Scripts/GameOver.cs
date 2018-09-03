using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameOver : MonoBehaviour {

    //Shows how many seconds are left text
    public TextMeshProUGUI secondsSurvived;
    //Shows the highScore of the game
    public TextMeshProUGUI highScoreGUI;
    //Int to keep the highScore
    int highscore;
    //GameOver panel
    public GameObject panel;
     

	// Use this for initialization
	void Start () {

        //Runs the start method of the Timer
        FindObjectOfType<Timer>().OnTimerOver += OnGameOver;

        highscore = PlayerPrefs.GetInt("High Score");

	}

    public void OnGameOver(){
        //Sets the panel active
        panel.SetActive(true);
        //Updates the highscore
        secondsSurvived.GetComponent<TextMeshProUGUI>().text = (Time.timeSinceLevelLoad.ToString("0")+" seconds");
        //Stops playing the main song
        AudioManager.instance.Stop("Game");
        //Setting the highscore
        SetHighScore();

    }

    void SetHighScore()
    {
        int score = Mathf.RoundToInt(Time.timeSinceLevelLoad);
        if(score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("High Score",highscore);
        }
        highScoreGUI.text= (highscore.ToString()+ " seconds");
    
    }
}