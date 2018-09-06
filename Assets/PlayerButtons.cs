using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerButtons : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)&&Input.mousePosition.x>(Screen.width/2)&&transform.position.x<3)
        {
            transform.Translate(new Vector3(1,0,0)*Time.deltaTime*6);
        }
        else if (Input.GetMouseButton(0) && Input.mousePosition.x < (Screen.width/2) && transform.position.x > -3)
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 6);
        }
    }
}
