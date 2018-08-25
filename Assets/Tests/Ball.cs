using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

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

        rigid.velocity = new Vector3(rigid.velocity.x, 0, rigid.velocity.z);
    }

    public void RestartBall()
    {
        startTime = 2f;
        start = false;
        transform.position = new Vector3(0, 0.01f, 0);
        rigid.velocity = new Vector3(0, 0, 0);
    }

    [UnityTest]
    public IEnumerator Test_Ball_YVelocity()
    {
        var go = new GameObject();
        go.AddComponent<Ball>();
        go.AddComponent<Rigidbody>();


        yield return new WaitForSeconds(5f);

        Assert.AreEqual(go.GetComponent<Rigidbody>().velocity.y, 0);
    }
}
