using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public int score = 0;

	// Use this for initialization
	void Start () {
		if (instance == null) // if there is no GameManager do not destroy on load
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else // if there is another GameManager... destroy yourself 
        {
            instance.score = 0;
            Destroy(gameObject);
        }
	}
}
