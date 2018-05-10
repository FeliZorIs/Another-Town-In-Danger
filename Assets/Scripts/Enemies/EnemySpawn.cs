using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject[] monsters;

    public GameObject gameManager;
    GameObject Monster;
    float randX;
    float posY;
    public float offsetX;
    public float offsetY;
    Vector2 whereToSpawn;
    public float spawnrate;
    private float spawnrate2;
    float nextSpawn = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawn)
        {
            spawnrate2 = Random.Range(spawnrate, spawnrate+5);
            nextSpawn = Time.time + spawnrate2;
            randX = Random.Range(transform.position.x-offsetX, transform.position.x + offsetX);
            posY = transform.position.y + offsetY;
            whereToSpawn = new Vector2(randX, posY);
            chooseMonster();
            Instantiate(Monster, whereToSpawn, Quaternion.identity);
            gameManager.gameObject.GetComponent<ScoreDif_Manager>().CurrentMonsters+=1;

            if (spawnrate <= 0)
            { spawnrate = 0; }
        }
	}

    public void chooseMonster()
    {
        int RandNum = Random.Range(0, monsters.Length);
        for (int i = 0; i < monsters.Length; i++)
        {
            if (i == RandNum)
            { Monster = monsters[i]; }
        }

    }
}
