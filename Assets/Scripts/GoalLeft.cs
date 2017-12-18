using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalLeft : MonoBehaviour
{
    public int rightWins;
    public Text RightScore;
    public int startRight = 0;
    
	// Use this for initialization
	void Start ()
    {
        Scores.rightScore = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        RightScore.text = "" + Scores.rightScore;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        startRight++;
        Scores.rightScore++;
        if (Scores.rightScore == 3 && Scores.currentLevel == 1)
        {
            rightWins++;
            SceneManager.LoadScene(sceneName: "lvl2");
            startRight = 0;
            Scores.rightScore = 0;
            RightScore.text = "" + RightScore;
            Scores.currentLevel++;
            System.Threading.Thread.Sleep(100);
        }

        if (Scores.leftScore == 3 && Scores.currentLevel == 2)
        {
            rightWins++;
            SceneManager.LoadScene(sceneName: "lvl3");
            startRight = 0;
            Scores.rightScore = 0;
            RightScore.text = "" + RightScore;
            Scores.currentLevel++;
            System.Threading.Thread.Sleep(100);
        }

        if (Scores.leftScore == 3 && Scores.currentLevel == 3)
        {
            rightWins++;
            SceneManager.LoadScene(sceneName: "endscreen");
            startRight = 0;
            Scores.rightScore = 0;
            RightScore.text = "" + RightScore;
            Scores.currentLevel++;
            System.Threading.Thread.Sleep(100);
        }
    }
}