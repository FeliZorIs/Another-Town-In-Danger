using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemyRed"))
        {
            //Debug.Log("Slashed " + collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }
}
