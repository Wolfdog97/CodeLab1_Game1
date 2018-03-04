using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockScript: MonoBehaviour
{

    public GameObject victoryObj;
    public bool endingGame;

    Rigidbody rb;

    public float endTime = 10f;
    public float deathTime = 3f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTiggerEnter(Collider other)
    {
        Debug.Log("I got hit");

        Destroy(Instantiate(victoryObj, transform.position, transform.rotation), deathTime);

        //rb.isKinematic = false;
        // rb.detectCollisions = false;

        //endingGame = true;

        GameManager.instance.score++;
        Destroy(other.gameObject);

        //Invoke("EndGame", endTime);

    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndScreen");
    }

}
