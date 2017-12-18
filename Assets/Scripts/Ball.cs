using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    System.Random rnd = new System.Random();
    Paddle paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;

	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    void Update() {
        
        float xaxis = rnd.Next(-10, 10);
        if (!gameStarted) // if(gameStarted == false)
        {
            this.transform.position = new Vector3(0, 0, -9);
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(xaxis, 10);
        }

        
        
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "ScoreOnLeft" || col.gameObject.name == "ScoreOnRight")
        {
            gameStarted = false;
        }
    }

}
