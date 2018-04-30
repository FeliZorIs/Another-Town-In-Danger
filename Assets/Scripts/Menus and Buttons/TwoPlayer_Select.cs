using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TwoPlayer_Select : MonoBehaviour {

    public Button P1Button;
    public Button P2Button;
    public Button P3Button;
    public Button P4Button;

    public GameObject Warrior;
    public GameObject Archer;
    public GameObject Mage;
    public GameObject Cleric;

    public GameObject P1_health;
    public GameObject P2_health;
    public GameObject P3_health;
    public GameObject P4_health;

    public Camera P1Cam;
    public Camera P2Cam;
    public Camera P3Cam;
    public Camera P4Cam;

    Rect P1CamRect = new Rect(0, 0, .5f, 1);
    Rect P2CamRect = new Rect(.5f, 0, .5f, 1);

    static int Player1;
    static int Player2;

    bool FirstChoice = false;
    bool SecondChoice = false;

    static bool Allset2 = false;
    public GameObject Filler;

    public void Start()
    {
        if (Allset2)
        {
            Filler.gameObject.SetActive(true);
        }

     //-----------------------------------------------------------------------------
     //                                 Player Spawns
     //-----------------------------------------------------------------------------

        //Player1 Spawn
        if (Player1 == 1)
        {
            Warrior.gameObject.SetActive(true);
            P1_health.gameObject.SetActive(true);
            P1Cam.rect = P1CamRect;

            Warrior.gameObject.GetComponentInChildren<ATIND_PlayerController>().enabled = true;
            Warrior.gameObject.GetComponentInChildren<Player1AsP2>().enabled = false;
            Warrior.gameObject.GetComponentInChildren<Player1AsP3>().enabled = false;
            Warrior.gameObject.GetComponentInChildren<Player1AsP4>().enabled = false;
        }

        if (Player1 == 2)
        {
            Archer.gameObject.SetActive(true);
            P2_health.gameObject.SetActive(true);
            P2Cam.rect = P1CamRect;

            Archer.gameObject.GetComponentInChildren<Player2_Controller>().enabled = true;
            Archer.gameObject.GetComponentInChildren<Player2AsP2>().enabled = false;
            Archer.gameObject.GetComponentInChildren<Player2AsP3>().enabled = false;
            Archer.gameObject.GetComponentInChildren<Player2AsP4>().enabled = false;
        }

        if (Player1 == 3)
        {
            Mage.gameObject.SetActive(true);
            P3_health.gameObject.SetActive(true);
            P3Cam.rect = P1CamRect;

            Mage.gameObject.GetComponentInChildren<Player3_Controller>().enabled = true;
            Mage.gameObject.GetComponentInChildren<Player3AsP2>().enabled = false;
            Mage.gameObject.GetComponentInChildren<Player3AsP3>().enabled = false;
            Mage.gameObject.GetComponentInChildren<Player3AsP4>().enabled = false;
        }

        if (Player1 == 4)
        {
            Cleric.gameObject.SetActive(true);
            P4_health.gameObject.SetActive(true);
            P4Cam.rect = P1CamRect;

            Cleric.gameObject.GetComponentInChildren<Player4_Controller>().enabled = true;
            Cleric.gameObject.GetComponentInChildren<Player4AsP2>().enabled = false;
            Cleric.gameObject.GetComponentInChildren<Player4AsP3>().enabled = false;
            Cleric.gameObject.GetComponentInChildren<Player4AsP4>().enabled = false;
        }

        //Player2 Spawn
        if (Player2 == 1)
        {
            Warrior.gameObject.SetActive(true);
            P1_health.gameObject.SetActive(true);
            P1Cam.rect = P2CamRect;
            P1Cam.GetComponent<AudioListener>().enabled = false;

            P1_health.transform.GetChild(0).transform.localPosition = new Vector3(78, 300, 0);
            P1_health.transform.GetChild(1).transform.localPosition = new Vector3(48, 300, 0);

            Warrior.gameObject.GetComponentInChildren<ATIND_PlayerController>().enabled = false;
            Warrior.gameObject.GetComponentInChildren<Player1AsP2>().enabled = true;
            Warrior.gameObject.GetComponentInChildren<Player1AsP3>().enabled = false;
            Warrior.gameObject.GetComponentInChildren<Player1AsP4>().enabled = false;
        }

        if (Player2 == 2)
        {
            Archer.gameObject.SetActive(true);
            P2_health.gameObject.SetActive(true);
            P2Cam.rect = P2CamRect;
            P2Cam.GetComponent<AudioListener>().enabled = false;

            Archer.gameObject.GetComponentInChildren<Player2_Controller>().enabled = false;
            Archer.gameObject.GetComponentInChildren<Player2AsP2>().enabled = true;
            Archer.gameObject.GetComponentInChildren<Player2AsP3>().enabled = false;
            Archer.gameObject.GetComponentInChildren<Player2AsP4>().enabled = false;

            P2_health.transform.GetChild(0).transform.localPosition = new Vector3(78, 300, 0);
            P2_health.transform.GetChild(1).transform.localPosition = new Vector3(48, 300, 0);
        }

        if (Player2 == 3)
        {
            Mage.gameObject.SetActive(true);
            P3_health.gameObject.SetActive(true);
            P3Cam.rect = P2CamRect;
            P3Cam.GetComponent<AudioListener>().enabled = false;

            Mage.gameObject.GetComponentInChildren<Player3_Controller>().enabled = false;
            Mage.gameObject.GetComponentInChildren<Player3AsP2>().enabled = true;
            Mage.gameObject.GetComponentInChildren<Player3AsP3>().enabled = false;
            Mage.gameObject.GetComponentInChildren<Player3AsP4>().enabled = false;

            P3_health.transform.GetChild(0).transform.localPosition = new Vector3(78, 300, 0);
            P3_health.transform.GetChild(1).transform.localPosition = new Vector3(48, 300, 0);
        }

        if (Player2 == 4)
        {
            Cleric.gameObject.SetActive(true);
            P4_health.gameObject.SetActive(true);
            P4Cam.rect = P2CamRect;
            P4Cam.GetComponent<AudioListener>().enabled = false;

            Cleric.gameObject.GetComponentInChildren<Player4_Controller>().enabled = false;
            Cleric.gameObject.GetComponentInChildren<Player4AsP2>().enabled = true;
            Cleric.gameObject.GetComponentInChildren<Player4AsP3>().enabled = false;
            Cleric.gameObject.GetComponentInChildren<Player4AsP4>().enabled = false;

            P4_health.transform.GetChild(0).transform.localPosition = new Vector3(78, 300, 0);
            P4_health.transform.GetChild(1).transform.localPosition = new Vector3(48, 300, 0);
        }
    }

    public void Update()
    {
        if (FirstChoice == true && SecondChoice == true)
        {
            SceneManager.LoadScene("Level1");
            Allset2 = true;
        }
    }

    //---------------------------------------------------------------------------------
    //                               Button Functionality
    //---------------------------------------------------------------------------------

    //Player1 button
    public void Player1_Choice()
    {
        if (FirstChoice == false)
        {
            Player1 = 1;
            P1Button.interactable = false;
            FirstChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == false)
        {
            Player2 = 1;
            P1Button.interactable = false;
            SecondChoice = true;
        }
    }

    //Player2 button
    public void Player2_Choice()
    {
        if (FirstChoice == false)
        {
            Player1 = 2;
            P2Button.interactable = false;
            FirstChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == false)
        {
            Player2 = 2;
            P2Button.interactable = false;
            SecondChoice = true;
        }
    }

    //Player3 button
    public void Player3_Choice()
    {
        if (FirstChoice == false)
        {
            Player1 = 3;
            P3Button.interactable = false;
            FirstChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == false)
        {
            Player2 = 3;
            P3Button.interactable = false;
            SecondChoice = true;
        }
    }

    //Player4 button
    public void Player4_Choice()
    {
        if (FirstChoice == false)
        {
            Player1 = 4;
            P4Button.interactable = false;
            FirstChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == false)
        {
            Player2 = 4;
            P4Button.interactable = false;
            SecondChoice = true;
        }
    }

    //--------------------------------------------------------------------------------------
    //                                  Back and Exit Game
    //--------------------------------------------------------------------------------------

    public void FalseOnBack()
    {
        FirstChoice = false;
        if (!P1Button.interactable || !P2Button.interactable || !P3Button.interactable || !P4Button.interactable)
        {
            P1Button.interactable = true;
            P2Button.interactable = true;
            P3Button.interactable = true;
            P4Button.interactable = true;
        }
    }

    public void Exit2Player()
    {
        P1_health.SetActive(false);
        Warrior.SetActive(false);

        P2_health.SetActive(false);
        Archer.SetActive(false);

        P3_health.SetActive(false);
        Mage.SetActive(false);

        P4_health.SetActive(false);
        Cleric.SetActive(false);

        Allset2 = false;
        Filler.SetActive(false);

        Player1 = 0;
        Player2 = 0;

        Time.timeScale = 1;
    }
}
