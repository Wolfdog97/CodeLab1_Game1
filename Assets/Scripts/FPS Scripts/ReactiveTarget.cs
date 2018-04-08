using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {

    public void ReactToHit()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if(behavior != null)
        {
            behavior.SetAlive(false);
        }

        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0); // Toppe the enemy, wait 1.5 secounds then destroy the enemy

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject); // make sure to use (this.gameObject) (this) would refer to the script
    }
}
