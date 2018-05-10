using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players_Health : MonoBehaviour {

    public GameObject gameManager;

    public float health = 5;
    public GameObject HealthBar;
    public GameObject YouLose;
    public Text causeOfDeath;
    Animator anim;

	// Use this for initialization
	void Start ()
    { }
	
	// Update is called once per frame
	void Update ()
    {
        healthFunc();
	}

    public void healthFunc()
    {
        HealthBar.gameObject.transform.localScale = new Vector3(health / 3, HealthBar.transform.localScale.y, 1);
        if (health <= 0 && this.gameObject.name == "Warrior")
        {
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<ATIND_PlayerController>().speed = 0;
            GetComponent<Player1AsP2>().speed = 0;
            GetComponent<Player1AsP3>().speed = 0;
            GetComponent<Player1AsP4>().speed = 0;

            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
            gameManager.GetComponent<DeathManager>().W_isDead = true;
        }

        if (health <= 0 && this.gameObject.name == "Archer")
        {
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<Player2_Controller>().speed = 0;
            GetComponent<Player2AsP2>().speed = 0;
            GetComponent<Player2AsP3>().speed = 0;
            GetComponent<Player2AsP4>().speed = 0;

            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
            gameManager.GetComponent<DeathManager>().A_isDead = true;
        }

        if (health <= 0 && this.gameObject.name == "Mage")
        {
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<Player3_Controller>().speed = 0;
            GetComponent<Player3AsP2>().speed = 0;
            GetComponent<Player3AsP3>().speed = 0;
            GetComponent<Player3AsP4>().speed = 0;

            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
            gameManager.GetComponent<DeathManager>().M_isDead = true;
        }

        if (health <= 0 && this.gameObject.name == "Cleric")
        {
            anim = GetComponent<Animator>();
            anim.SetBool("Dead", true);
            GetComponent<Player4_Controller>().speed = 0;
            GetComponent<Player4AsP2>().speed = 0;
            GetComponent<Player4AsP3>().speed = 0;
            GetComponent<Player4AsP4>().speed = 0;

            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
            gameManager.GetComponent<DeathManager>().C_isDead = true;
        }

        //provides a max health cap
        if (health >= 5)
        { health = 5; }
    }

   }
