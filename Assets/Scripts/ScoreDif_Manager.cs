using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDif_Manager : MonoBehaviour {

    public GameObject[] spawners;

    public Text secSurvived;
    public int CurrentMonsters = 0;
    private float Score;
    public float Timer;

    public float SpawnRateMult = 1;

	// Use this for initialization
	void Start () {
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Score += Time.deltaTime;
        Timer += Time.deltaTime;

        secSurvived.text = "You survived for " + Score + " seconds.";
        if (Timer%10 > 0 && Timer%10 <.5f)
        {
            SpawnRateMult *= 1.0001f;
            for (int i = 0; i < spawners.Length-1; i++)
            {
                spawners[i].gameObject.GetComponent<EnemySpawn>().spawnrate /= SpawnRateMult;
            }
        }

	}
}
