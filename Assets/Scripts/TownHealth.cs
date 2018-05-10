using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownHealth : MonoBehaviour
{
    public float townHealth;

    public GameObject T_Healthbar;
    public GameObject YouLose;
    public Text causeOfDeath;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        T_Healthbar.gameObject.transform.localScale = new Vector3(townHealth / 5, T_Healthbar.transform.localScale.y, 1);

        if (townHealth <= 0)
        {
            Time.timeScale = 0;
            YouLose.gameObject.SetActive(true);
            causeOfDeath.text = "Town was overrun";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemyRed")
        {
            townHealth--;
        }
    }
}
