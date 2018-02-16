using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float sens = 200f;
	
	// Update is called once per frame
	void Update () {
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        transform.Translate(0, 0, z);

        transform.Rotate(-mouseY * sens * Time.deltaTime, mouseX * sens * Time.deltaTime, 0f);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);
    }
}
