using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float moveSpeed = 0.3f;

    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;

    public GameObject endBlock;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed, 0, 0);
        }
        if (Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
    }
}
