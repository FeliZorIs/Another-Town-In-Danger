using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players_Health : MonoBehaviour {

    public float health = 10;
    public GameObject HealthBar;
    Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        healthFunc();
	}

    public void healthFunc()
    {
        HealthBar.gameObject.transform.localScale = new Vector3(health / 3, HealthBar.transform.localScale.y, 1);
        if (health <= 0 && this.gameObject.name == "warrior_m_1")
        {
            Debug.Log("lol, get rekt!");
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<ATIND_PlayerController>().isDead = true;
            GetComponent<ATIND_PlayerController>().speed = 0;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (health <= 0 && this.gameObject.name == "ranger_f_1")
        {
            Debug.Log("lol, get rekt!");
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<Player2_Controller>().isDead = true;
            GetComponent<Player2_Controller>().speed = 0;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (health <= 0 && this.gameObject.name == "mage_m_1")
        {
            Debug.Log("lol, get rekt!");
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<Player3_Controller>().isDead = true;
            GetComponent<Player3_Controller>().speed = 0;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (health <= 0 && this.gameObject.name == "healer_f_1")
        {
            Debug.Log("lol, get rekt!");
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<Player4_Controller>().isDead = true;
            GetComponent<Player4_Controller>().speed = 0;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
