using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggers : MonoBehaviour {
    [SerializeField] GuiScores scores;
    [SerializeField] int identifier;
	// Use this for initialization
	void Start() { 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (identifier==1)
            {
                scores.SumarPlayer();
            }
            if (identifier == 0)
            {
                scores.SumarAi();
            }
            Ball ballScript = other.GetComponent<Ball>();
            ballScript.RestartBall();
        }
    }
}
