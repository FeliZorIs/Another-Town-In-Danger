using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public GameObject pauseMenu;
    public bool isMainMenu;
    public static int PlayerChoice;

    public GameObject PlayerI;
    public GameObject PlayerII;
    public GameObject PlayerIII;
    public GameObject PlayerIV;

    public GameObject P1_health;
    public GameObject P2_health;
    public GameObject P3_health;
    public GameObject P4_health;

    public void Start()
    {
        if (PlayerChoice == 1)
        {
            PlayerI.gameObject.SetActive(true);
            P1_health.gameObject.SetActive(true);

            PlayerI.GetComponentInChildren<ATIND_PlayerController>().enabled = true;
            PlayerI.GetComponentInChildren<Player1AsP2>().enabled = false;
            PlayerI.GetComponentInChildren<Player1AsP3>().enabled = false;
            PlayerI.GetComponentInChildren<Player1AsP4>().enabled = false;
        }

        if (PlayerChoice == 2)
        {
            PlayerII.gameObject.SetActive(true);
            P2_health.gameObject.SetActive(true);

            PlayerII.GetComponentInChildren<Player2_Controller>().enabled = true;
            PlayerII.GetComponentInChildren<Player2AsP2>().enabled = false;
            PlayerII.GetComponentInChildren<Player2AsP3>().enabled = false;
            PlayerII.GetComponentInChildren<Player2AsP4>().enabled = false;
        }

        if (PlayerChoice == 3)
        {
            PlayerIII.gameObject.SetActive(true);
            P3_health.gameObject.SetActive(true);

            PlayerIII.GetComponentInChildren<Player3_Controller>().enabled = true;
            PlayerIII.GetComponentInChildren<Player3AsP2>().enabled = false;
            PlayerIII.GetComponentInChildren<Player3AsP3>().enabled = false;
            PlayerIII.GetComponentInChildren<Player3AsP4>().enabled = false;
        }

        if (PlayerChoice == 4)
        {
            PlayerIV.gameObject.SetActive(true);
            P4_health.gameObject.SetActive(true);

            PlayerIV.GetComponentInChildren<Player4_Controller>().enabled = true;
            PlayerIV.GetComponentInChildren<Player4AsP2>().enabled = false;
            PlayerIV.GetComponentInChildren<Player4AsP3>().enabled = false;
            PlayerIV.GetComponentInChildren<Player4AsP4>().enabled = false;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            pauseGame();
        }
    }

    public void pauseGame()
    {
        if (!isMainMenu)
        {
            if (pauseMenu.gameObject.activeInHierarchy == false)
            {
                Time.timeScale = 0;
                pauseMenu.gameObject.SetActive(true);
            }

            else
            {
                Time.timeScale = 1;
                pauseMenu.gameObject.SetActive(false);
            }
        }
        else
        {
            return;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void playerOne()
    {
        PlayerChoice = 1;
        SceneManager.LoadScene("Level1");
    }

    public void playerTwo()
    {
        PlayerChoice = 2;
        SceneManager.LoadScene("Level1");
    }

    public void playerThree()
    {
        PlayerChoice = 3;
        SceneManager.LoadScene("Level1");
    }

    public void playerFour()
    {
        PlayerChoice = 4;
        SceneManager.LoadScene("Level1");
    }

    //--------------------------------------------------------------------------------------
    //                                  Back and Exit Game
    //--------------------------------------------------------------------------------------

    public void Exit1Player()
    {
        P1_health.SetActive(false);
        PlayerI.SetActive(false);

        P2_health.SetActive(false);
        PlayerII.SetActive(false);

        P3_health.SetActive(false);
        PlayerIII.SetActive(false);

        P4_health.SetActive(false);
        PlayerIV.SetActive(false);

        PlayerChoice = 0;

        Time.timeScale = 1;
    }
}
