using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownCam : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    GameObject Player;
    Vector3 playerPos;

	// Camera chooses who to follow based on the character that is selected
	void Start ()
    {

    }
	
	// Camera follows selected player
	void Update () {

        if (Player1.activeInHierarchy == true)
        {
            Player = Player1;
        }

        if (Player2.activeInHierarchy == true)
        {
            Player = Player2;
        }

        if (Player3.activeInHierarchy == true)
        {
            Player = Player3;
        }

        if (Player3.activeInHierarchy == true)
        {
            Player = Player3;
        }

        Debug.Log(Player.name);
        playerPos = Player.transform.position;
        this.transform.position = new Vector3(playerPos.x, playerPos.y, this.transform.position.z);
	}
}
