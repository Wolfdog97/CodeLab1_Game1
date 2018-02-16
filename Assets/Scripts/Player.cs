using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 0.3f;

    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;



	void Update () {
        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);
        }
       
    }
}
