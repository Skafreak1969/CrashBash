using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAi : MonoBehaviour {
    bool side;
	// Use this for initialization
	void Start () {
        side = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (side)
        {
            transform.Translate(transform.right * Time.deltaTime * 9.5f);
            if (transform.position.x > 4.3)
            {
                side = false;
            }
        }
        else
        {
            transform.Translate(-transform.right * Time.deltaTime * 9.5f);
            if (transform.position.x < -4.3)
            {
                side = true;
            }
        }
        
	}
}
