using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour {

    private Camera _camera;

	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>();

        // Hiding the mouse cursor at the center of the screen.
        Cursor.lockState = CursorLockMode.Locked; // locking the cursor
        Cursor.visible = false; // making it invisable
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            // Finding the middle of the screen using pixelWith and pixelHeight
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);

            Ray ray = _camera.ScreenPointToRay(point); // Create a ray at the position using ScreenPointToRay
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // The raycast fills the reference variable with information. hit =  the object hit by the ray 
            {
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                if(target != null)
                {
                    target.ReactToHit();

                    Debug.Log("Target Hit");
                }
                else
                {
                    StartCoroutine(SphereIndicator(hit.point));
                    Debug.Log("Hit " + hit.point); // Retrieve coordinates where the ray hit
                }
            }
        }
	}

    private void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;

        GUI.Label(new Rect(posX, posY, size, size), "*"); // The command GUI.Label() dusplays text on screen
    }

    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;

        yield return new WaitForSeconds(1); // The yield keyword tells the couroutine where to pause

        Destroy(sphere); // Remember to remove objects to clear memory
    }
}
