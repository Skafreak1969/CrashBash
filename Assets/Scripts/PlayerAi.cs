using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAi : MonoBehaviour {
    private bool side;

    private float speed = 2;

    [SerializeField]
    private GameObject bola;

	// Use this for initialization
	void Start () {
        side = true;
	}
	
	// Update is called once per frame
	void Update () {
        /*if (side)
        {
            transform.Translate(transform.right * Time.deltaTime * 6f);
            if (transform.localPosition.x > 0.3f)
            {
                side = false;
            }
        }
        else
        {
            transform.Translate(-transform.right * Time.deltaTime * 6f);
            if (transform.localPosition.x < -0.3f)
            {
                side = true;
            }
        }*/
        transform.position = Vector3.Lerp( transform.position, new Vector3 (bola.transform.position.x, transform.position.y, transform.position.z), Time.deltaTime * speed);

    }
}
