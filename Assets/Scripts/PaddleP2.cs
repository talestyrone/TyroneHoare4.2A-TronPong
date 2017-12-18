using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleP2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float positionY = transform.position.y;
        Vector3 newPaddlePos = this.transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (positionY > 4.2f)
            {
                positionY = 4.2f;
            }
            else
            {
                System.Threading.Thread.Sleep(25);
                newPaddlePos.y++;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (positionY < -4.2f)
            {
                positionY = -4.2f;
            }
            else
            {
                System.Threading.Thread.Sleep(25);
                newPaddlePos.y--;
            }
        }  
        
        this.transform.position = newPaddlePos;
        
    }
}
