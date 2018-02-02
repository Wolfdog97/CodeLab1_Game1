using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {

    public KeyCode throwing = KeyCode.Space;

    public float throwingForce = 50f;

    public GameObject ballPrefab;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(throwing))
        {
            throwBall();
        }
	}

    void throwBall()
    {
        GameObject ball = Instantiate(ballPrefab, transform.position, transform.rotation);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwingForce, ForceMode.VelocityChange);
    }
}
