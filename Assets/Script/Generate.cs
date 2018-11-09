using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generate : MonoBehaviour {

    public GameObject rocks;
    public Text ScoreText;
    public Text Score;
    public static int score = 0;

    void Start()
    {
        Score.text = "Score";
        score = 0;
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }

    void CreateObstacle()
    {
        Instantiate(rocks);
        score++;
    }
    void Update()
    {
        ScoreText.text = score.ToString();
    }
}
