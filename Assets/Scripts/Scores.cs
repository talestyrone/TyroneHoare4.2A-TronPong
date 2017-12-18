using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour {
    public static int leftScore;
    public static int rightScore;
    public Text WinnerName;
    public static int currentLevel = 1;

    public int leftWins;
    public int rightWins;
    

    // Use this for initialization
    void Start () {
		if (leftWins < rightWins)
        {
            WinnerName.text = "Player 1!";
        }

        if (leftWins > rightWins)
        {
            WinnerName.text = "Player 2!";
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
