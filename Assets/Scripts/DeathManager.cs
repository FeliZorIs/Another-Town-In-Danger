using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    public GameObject Warrior;
    public GameObject Archer;
    public GameObject Mage;
    public GameObject Cleric;

    public GameObject YouLose;
    public Text causeOfDeath;

    bool fourplayer = false;
    bool threeplayer = false;
    bool twoplayer = false;
    bool singleplayer = false;

    public bool W_isDead;
    public bool A_isDead;
    public bool M_isDead;
    public bool C_isDead;

	// Use this for initialization
	void Start ()
    {
        GameMode();
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerDeaths();	
	}

    public void GameMode()
    {
        //------Checks if all players are present
        if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true &&
              Cleric.gameObject.activeInHierarchy == true)
        { fourplayer = true; Debug.Log("Four Players"); }

        //------checks out of 3 players present (1/4)
        else if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
        { threeplayer = true; Debug.Log("Three Players"); }
        //(2/4)
        else if (Cleric.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
        { threeplayer = true; Debug.Log("Three Players"); }
        //(3/4)
        else if (Warrior.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
        { threeplayer = true; Debug.Log("Three Players"); }
        //(4/4)
        else if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
        { threeplayer = true; Debug.Log("Three Players"); }

        //------checks out of 2 players (1/6)
        else if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true)
        { twoplayer = true; Debug.Log("Two Players"); }
        //(2/6)
        else if (Warrior.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
        { twoplayer = true; Debug.Log("Two Players"); }
        //(3/6)
        else if (Warrior.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
        { twoplayer = true; Debug.Log("Two Players"); }
        //(4/6)
        else if (Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
        { twoplayer = true; Debug.Log("Two Players"); }
        //(5/6)
        else if (Archer.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
        { twoplayer = true; Debug.Log("Two Players"); }
        //(6/6)
        else if (Mage.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
        { twoplayer = true; Debug.Log("Two Players"); }

        //------chooses out of 1 player
        else if (Warrior.gameObject.activeInHierarchy == true || Archer.gameObject.activeInHierarchy == true || Mage.gameObject.activeInHierarchy == true ||
                 Cleric.gameObject.activeInHierarchy == true)
        { singleplayer = true; Debug.Log("Single Player"); }
    }

    public void playerDeaths()
    {
        //------If all four players are dead
        if (fourplayer == true)
        {
            if (W_isDead == true && A_isDead == true && M_isDead == true && C_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
        }

        //------If all 3 players are dead
        else if (threeplayer == true)
        {
            //(1/4)
            if (W_isDead == true && A_isDead == true && M_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(2/4)
            else if (C_isDead == true && A_isDead == true && M_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(3/4)
            else if (W_isDead == true && C_isDead == true && M_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(4/4)
            else if (W_isDead == true && A_isDead == true && C_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
        }

        //------If all 2 players are dead
        else if (twoplayer == true)
        {
            //(1/6)
            if (W_isDead == true && A_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(2/6)
            else if (W_isDead == true && M_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(3/6)
            else if (W_isDead == true && C_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(4/6)
            else if (M_isDead == true && A_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(5/6)
            else if (C_isDead == true && A_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
            //(6/6)
            else if (M_isDead == true && C_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
        }

        //------If all 1 player is dead        
        else if (singleplayer == true)
        {
            if (W_isDead == true || A_isDead == true || M_isDead == true || C_isDead == true)
            {
                Time.timeScale = 0;
                YouLose.gameObject.SetActive(true);
                causeOfDeath.text = "All players died";
            }
        }

    }
}
