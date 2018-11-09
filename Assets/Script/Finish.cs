using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

    public Text ScoreKamu;
    public Text ScoreTot;
    public Text Tittle;
    public Text highScore;

    public Text highScore_txt;
	// Use this for initialization
	void Start () {
        ScoreKamu.text = "Score";
        ScoreTot.text = " " + Generate.score;
        Tittle.text = "GAME OVER";
        highScore_txt.text = "High Score";
        
        
        if (Generate.score > PlayerPrefs.GetInt("highScore",0))
        {
            PlayerPrefs.SetInt("highScore",Generate.score);
            
        }
        highScore.text = PlayerPrefs.GetInt("highScore",0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
