using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiScores : MonoBehaviour {
    [SerializeField] Text scorePlayerTxt;
    [SerializeField] Text scoreAiTxt;
    int scorePlayer;
    int scoreAi;
    // Use this for initialization
    void Start () {
		
	}

    public void SumarPlayer()
    {
        scorePlayer++;
    }

    public void SumarAi()
    {
        scoreAi++;
    } 
	
	// Update is called once per frame
	void Update () {
        scorePlayerTxt.text = scorePlayer.ToString();
        scoreAiTxt.text = scoreAi.ToString();
	}
}
