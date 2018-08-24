using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    Rigidbody rigid;
    bool start;
    float startTime;
	// Use this for initialization
	void Start () {
        rigid = gameObject.GetComponent<Rigidbody>();
        start = false;
        startTime = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        if (!start)
        {
            startTime -= Time.deltaTime;
            if (startTime<=0)
            {
                rigid.AddForce(new Vector3(-0.05f, 0, -0.2f), ForceMode.Impulse);
                start = true;
            }
        }
        if (start)
        {
            if (rigid.velocity.z < 1 )
            {
                rigid.AddForce(new Vector3(0, 0, -1f));
            }
            if (rigid.velocity.x < 1)
            {
                rigid.AddForce(new Vector3(-1f, 0, 0));
            }
        }
    }

    public void RestartBall()
    {
        startTime = 2f;
        start = false;
        transform.position = new Vector3(0, 0.01f, 0);
        rigid.velocity = new Vector3(0, 0, 0);
    }
}
