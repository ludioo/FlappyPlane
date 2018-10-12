using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {

    public Text ScoreKamu;
    public Text ScoreTot;
    public Text Tittle;
	// Use this for initialization
	void Start () {
        ScoreKamu.text = "Score Kamu";
        ScoreTot.text = " " + Generate.score;
        Tittle.text = "GAME OVER";
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
