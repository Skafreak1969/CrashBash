using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerButtons : MonoBehaviour {

	void Update () {
        if (Input.GetMouseButton(0)&&Input.mousePosition.x>(Screen.width/2)&&transform.localPosition.x<0.3f)
        {
            transform.Translate(new Vector3(1,0,0)*Time.deltaTime*6);
        }
        else if (Input.GetMouseButton(0) && Input.mousePosition.x < (Screen.width/2) && transform.localPosition.x > -0.3f)
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 6);
        }
    }
}
