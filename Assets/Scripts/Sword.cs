using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    public GameObject healthPot;
    public int HPercent;

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemyRed"))
        {
            //Debug.Log("Slashed " + collision.gameObject.name);
            int percent = Random.Range(1, 101);
            if (HPercent > percent)
            {
                Instantiate(healthPot, collision.transform.position, Quaternion.identity);
            }
            Destroy(collision.gameObject);
        }
    }
}
