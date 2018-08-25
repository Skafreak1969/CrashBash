using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

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
            transform.Translate(transform.right * Time.deltaTime * 6f);
            if (transform.position.x > 1.6f)
            {
                side = false;
            }
        }
        else
        {
            transform.Translate(-transform.right * Time.deltaTime * 6f);
            if (transform.position.x < -1.6f)
            {
                side = true;
            }
        }
        
	}

    [UnityTest]
    public IEnumerator Test_AI_Position()
    {
        var go = new GameObject();
        go.AddComponent<PlayerAi>();

        
        yield return new WaitForSeconds(1f);

        Assert.Less(go.transform.position.x, 1.6f);
    }
}
