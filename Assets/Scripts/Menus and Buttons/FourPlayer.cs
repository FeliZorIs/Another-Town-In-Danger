using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FourPlayer : MonoBehaviour {

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

    Rect P1CamRect = new Rect(.0f, .5f, .5f, .5f);
    Rect P2CamRect = new Rect(.5f, .5f, .5f, .5f);
    Rect P3CamRect = new Rect(.0f, 0, .5f, .5f);
    Rect P4CamRect = new Rect(.5f, .0f, .5f, .5f);

    Vector3 Player1Bar = new Vector3(-610, 325, 0);
    Vector3 Player1Icon = new Vector3(-640, 325, 0);
    Vector3 Player2Bar = new Vector3(80, 325, 0);
    Vector3 Player2Icon = new Vector3(50, 325, 0);
    Vector3 Player3Bar = new Vector3(-610, -50, 0);
    Vector3 Player3Icon = new Vector3(-640, -50, 0);
    Vector3 Player4Bar = new Vector3(80, -50, 0);
    Vector3 Player4Icon = new Vector3(50, -50, 0);

    public GameObject Filler;

    static int Player1;
    static int Player2;
    static int Player3;
    static int Player4;

    bool FirstChoice = false;
    bool SecondChoice = false;
    bool ThirdChoice = false;
    bool FourthChoice = false;

    static bool AllSet;

    public void Start()
    {
        if (AllSet == true)
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

            P1_health.transform.GetChild(0).transform.localPosition = Player1Bar;
            P1_health.transform.GetChild(1).transform.localPosition = Player1Icon;

            Warrior.GetComponentInChildren<ATIND_PlayerController>().enabled = true;
            Warrior.GetComponentInChildren<Player2AsP2>().enabled = false;
            Warrior.GetComponentInChildren<Player2AsP3>().enabled = false;
            Warrior.GetComponentInChildren<Player2AsP4>().enabled = false;
        }

        if (Player1 == 2)
        {
            Archer.gameObject.SetActive(true);
            P2_health.gameObject.SetActive(true);
            P2Cam.rect = P1CamRect;

            P2_health.transform.GetChild(0).transform.localPosition = Player1Bar;
            P2_health.transform.GetChild(1).transform.localPosition = Player1Icon;

            Archer.GetComponentInChildren<Player2_Controller>().enabled = true;
            Archer.GetComponentInChildren<Player2AsP2>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP3>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP4>().enabled = false;
        }

        if (Player1 == 3)
        {
            Mage.gameObject.SetActive(true);
            P3_health.gameObject.SetActive(true);
            P3Cam.rect = P1CamRect;

            P3_health.transform.GetChild(0).transform.localPosition = Player1Bar;
            P3_health.transform.GetChild(1).transform.localPosition = Player1Icon;

            Mage.GetComponentInChildren<Player3_Controller>().enabled = true;
            Mage.GetComponentInChildren<Player3AsP2>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP3>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP4>().enabled = false;
        }

        if (Player1 == 4)
        {
            Cleric.gameObject.SetActive(true);
            P4_health.gameObject.SetActive(true);
            P4Cam.rect = P1CamRect;

            P4_health.transform.GetChild(0).transform.localPosition = Player1Bar;
            P4_health.transform.GetChild(1).transform.localPosition = Player1Icon;

            Cleric.GetComponentInChildren<Player4_Controller>().enabled = true;
            Cleric.GetComponentInChildren<Player4AsP2>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP3>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP4>().enabled = false;
        }

        //Player2 Spawn
        if (Player2 == 1)
        {
            Warrior.gameObject.SetActive(true);
            P1_health.gameObject.SetActive(true);
            P1Cam.rect = P2CamRect;
            P1Cam.GetComponent<AudioListener>().enabled = false;

            P1_health.transform.GetChild(0).transform.localPosition = Player2Bar;
            P1_health.transform.GetChild(1).transform.localPosition = Player2Icon;

            Warrior.GetComponentInChildren<ATIND_PlayerController>().enabled = false;
            Warrior.GetComponentInChildren<Player1AsP2>().enabled = true;
            Warrior.GetComponentInChildren<Player1AsP3>().enabled = false;
            Warrior.GetComponentInChildren<Player1AsP4>().enabled = false;
        }

        if (Player2 == 2)
        {
            Archer.gameObject.SetActive(true);
            P2_health.gameObject.SetActive(true);
            P2Cam.rect = P2CamRect;
            P2Cam.GetComponent<AudioListener>().enabled = false;

            P2_health.transform.GetChild(0).transform.localPosition = Player2Bar;
            P2_health.transform.GetChild(1).transform.localPosition = Player2Icon;

            Archer.GetComponentInChildren<Player2_Controller>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP2>().enabled = true;
            Archer.GetComponentInChildren<Player2AsP3>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP4>().enabled = false;
        }

        if (Player2 == 3)
        {
            Mage.gameObject.SetActive(true);
            P3_health.gameObject.SetActive(true);
            P3Cam.rect = P2CamRect;
            P3Cam.GetComponent<AudioListener>().enabled = false;

            P3_health.transform.GetChild(0).transform.localPosition = Player2Bar;
            P3_health.transform.GetChild(1).transform.localPosition = Player2Icon;

            Mage.GetComponentInChildren<Player3_Controller>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP2>().enabled = true;
            Mage.GetComponentInChildren<Player3AsP3>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP4>().enabled = false;
        }

        if (Player2 == 4)
        {
            Cleric.gameObject.SetActive(true);
            P4_health.gameObject.SetActive(true);
            P4Cam.rect = P2CamRect;
            P4Cam.GetComponent<AudioListener>().enabled = false;

            P4_health.transform.GetChild(0).transform.localPosition = Player2Bar;
            P4_health.transform.GetChild(1).transform.localPosition = Player2Icon;

            Cleric.GetComponentInChildren<Player4_Controller>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP2>().enabled = true;
            Cleric.GetComponentInChildren<Player4AsP3>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP4>().enabled = false;
        }

        //Player3 spawn
        if (Player3 == 1)
        {
            Warrior.gameObject.SetActive(true);
            P1_health.gameObject.SetActive(true);
            P1Cam.rect = P3CamRect;
            P1Cam.GetComponent<AudioListener>().enabled = false;

            P1_health.transform.GetChild(0).transform.localPosition = Player3Bar;
            P1_health.transform.GetChild(1).transform.localPosition = Player3Icon;

            Warrior.GetComponentInChildren<ATIND_PlayerController>().enabled = false;
            Warrior.GetComponentInChildren<Player1AsP2>().enabled = false;
            Warrior.GetComponentInChildren<Player1AsP3>().enabled = true;
            Warrior.GetComponentInChildren<Player1AsP4>().enabled = false;
        }

        if (Player3 == 2)
        {
            Archer.gameObject.SetActive(true);
            P2_health.gameObject.SetActive(true);
            P2Cam.rect = P3CamRect;
            P2Cam.GetComponent<AudioListener>().enabled = false;

            P2_health.transform.GetChild(0).transform.localPosition = Player3Bar;
            P2_health.transform.GetChild(1).transform.localPosition = Player3Icon;

            Archer.GetComponentInChildren<Player2_Controller>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP2>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP3>().enabled = true;
            Archer.GetComponentInChildren<Player2AsP4>().enabled = false;
        }

        if (Player3 == 3)
        {
            Mage.gameObject.SetActive(true);
            P3_health.gameObject.SetActive(true);
            P3Cam.rect = P3CamRect;
            P3Cam.GetComponent<AudioListener>().enabled = false;

            P3_health.transform.GetChild(0).transform.localPosition = Player3Bar;
            P3_health.transform.GetChild(1).transform.localPosition = Player3Icon;

            Mage.GetComponentInChildren<Player3_Controller>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP2>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP3>().enabled = true;
            Mage.GetComponentInChildren<Player3AsP4>().enabled = false;
        }

        if (Player3 == 4)
        {
            Cleric.gameObject.SetActive(true);
            P4_health.gameObject.SetActive(true);
            P4Cam.rect = P3CamRect;
            P4Cam.GetComponent<AudioListener>().enabled = false;

            P4_health.transform.GetChild(0).transform.localPosition = Player3Bar;
            P4_health.transform.GetChild(1).transform.localPosition = Player3Icon;

            Cleric.GetComponentInChildren<Player4_Controller>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP2>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP3>().enabled = true;
            Cleric.GetComponentInChildren<Player4AsP4>().enabled = false;
        }

        //Player4 spawn
        if (Player4 == 1)
        {
            Warrior.gameObject.SetActive(true);
            P1_health.gameObject.SetActive(true);
            P1Cam.rect = P4CamRect;
            P1Cam.GetComponent<AudioListener>().enabled = false;

            P1_health.transform.GetChild(0).transform.localPosition = Player4Bar;
            P1_health.transform.GetChild(1).transform.localPosition = Player4Icon;

            Warrior.GetComponentInChildren<ATIND_PlayerController>().enabled = false;
            Warrior.GetComponentInChildren<Player1AsP2>().enabled = false;
            Warrior.GetComponentInChildren<Player1AsP3>().enabled = false;
            Warrior.GetComponentInChildren<Player1AsP4>().enabled = true;
        }

        if (Player4 == 2)
        {
            Archer.gameObject.SetActive(true);
            P2_health.gameObject.SetActive(true);
            P2Cam.rect = P4CamRect;
            P2Cam.GetComponent<AudioListener>().enabled = false;

            P2_health.transform.GetChild(0).transform.localPosition = Player4Bar;
            P2_health.transform.GetChild(1).transform.localPosition = Player4Icon;

            Archer.GetComponentInChildren<Player2_Controller>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP2>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP3>().enabled = false;
            Archer.GetComponentInChildren<Player2AsP4>().enabled = true;
        }

        if (Player4 == 3)
        {
            Mage.gameObject.SetActive(true);
            P3_health.gameObject.SetActive(true);
            P3Cam.rect = P4CamRect;
            P3Cam.GetComponent<AudioListener>().enabled = false;

            P3_health.transform.GetChild(0).transform.localPosition = Player4Bar;
            P3_health.transform.GetChild(1).transform.localPosition = Player4Icon;

            Mage.GetComponentInChildren<Player3_Controller>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP2>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP3>().enabled = false;
            Mage.GetComponentInChildren<Player3AsP4>().enabled = true;
        }

        if (Player4 == 4)
        {
            Cleric.gameObject.SetActive(true);
            P4_health.gameObject.SetActive(true);
            P4Cam.rect = P4CamRect;
            P4Cam.GetComponent<AudioListener>().enabled = false;

            P4_health.transform.GetChild(0).transform.localPosition = Player4Bar;
            P4_health.transform.GetChild(1).transform.localPosition = Player4Icon;

            Cleric.GetComponentInChildren<Player4_Controller>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP2>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP3>().enabled = false;
            Cleric.GetComponentInChildren<Player4AsP4>().enabled = true;
        }

    }

    public void Update()
    {
        if (FirstChoice == true && SecondChoice == true && ThirdChoice == true && FourthChoice == true)
        {
            SceneManager.LoadScene("Level1");
            AllSet = true;
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
        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == false)
        {
            Player3 = 1;
            P1Button.interactable = false;
            ThirdChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == true)
        {
            Player4 = 1;
            P1Button.interactable = false;
            FourthChoice = true;
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

        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == false)
        {
            Player3 = 2;
            P2Button.interactable = false;
            ThirdChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == true)
        {
            Player4 = 2;
            P2Button.interactable = false;
            FourthChoice = true;
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

        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == false)
        {
            Player3 = 3;
            P3Button.interactable = false;
            ThirdChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == true)
        {
            Player4 = 3;
            P3Button.interactable = false;
            FourthChoice = true;
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

        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == false)
        {
            Player3 = 4;
            P4Button.interactable = false;
            ThirdChoice = true;
        }

        else if (FirstChoice == true && SecondChoice == true && ThirdChoice == true)
        {
            Player4 = 4;
            P4Button.interactable = false;
            FourthChoice = true;
        }
    }

    //--------------------------------------------------------------------------------------
    //                                  Back and Exit Game
    //--------------------------------------------------------------------------------------

    public void FalseOnBack()
    {
        FirstChoice = false;
        SecondChoice = false;
        ThirdChoice = false;
        if (!P1Button.interactable || !P2Button.interactable || !P3Button.interactable || !P4Button.interactable)
        {
            P1Button.interactable = true;
            P2Button.interactable = true;
            P3Button.interactable = true;
            P4Button.interactable = true;
        }
    }

    public void Exit4Player()
    {
        P1_health.SetActive(false);
        Warrior.gameObject.SetActive(false);

        P2_health.SetActive(false);
        Archer.SetActive(false);

        P3_health.SetActive(false);
        Mage.SetActive(false);

        P4_health.SetActive(false);
        Cleric.SetActive(false);

        AllSet = false;
        Filler.SetActive(false);

        Player1 = 0;
        Player2 = 0;
        Player3 = 0;
        Player4 = 0;

        Time.timeScale = 1;
    }
}

