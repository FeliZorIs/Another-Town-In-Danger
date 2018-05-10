using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

[RequireComponent (typeof (Rigidbody2D))]
[RequireComponent(typeof(Seeker))]
public class EnemyAI : MonoBehaviour {

    //targets to chase
    bool targetFound = false;

    Transform target;
    public GameObject Town;
    public GameObject Warrior;
    public GameObject Archer;
    public GameObject Mage;
    public GameObject Cleric;

    bool SingleP;
    bool TwoP;
    bool ThreeP;
    bool FourP;

    //random number to choose between targets at spawn
    int randNum;
    int secondTarget;

    // how many times a second the path gets updated
    public float updateRate = 2f;

    // Caching
    private Seeker seeker;
    private Rigidbody2D rb;

    // the calculated path
    public Path path;

    //the AI's speed per second
    public float speed = 300f;
    public ForceMode2D fMode;

    [HideInInspector]
    public bool pathIsEnded = false;

    //max distance from the AI to the waypoint for it to continue to the next waypoint
    public float nextWaypointDistance = 3;

    // the waypoint we are currently moving towards
    private int currentWaypoint = 0;

    public void Start()
    {
        randNum = Random.RandomRange(1, 5);
        chooseTarget();
        Debug.Log(this.name + "'s " + "target: " + target);
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        if (target == null)
        {

            Debug.LogError("No Player Found? PANIC!");
            return;
        }

        // start path to the target position, return the result to the OnPathComplete method
        seeker.StartPath(transform.position, target.position, OnPathComplete);

        StartCoroutine (UpdatePath());

    }

    IEnumerator UpdatePath()
    {
        if (target == null)
        {
            yield return false;
        }
        seeker.StartPath(transform.position, target.position, OnPathComplete);
        yield return new WaitForSeconds(1f / updateRate);
        StartCoroutine(UpdatePath());
    }

    public void OnPathComplete(Path p)
    {
        //Debug.Log("We got a path. Did it have an error?" + p.error);
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    void FixedUpdate()
    {
        if (target == null)
        {
            //TODO: insert a player search here
            return;
        }

        //TODO: always look at player

        if (path == null)
            return;

        if (currentWaypoint >= path.vectorPath.Count)
        {
            if (pathIsEnded)
                return;

            Debug.Log("End of path  is reached.");
            pathIsEnded = true;
            return;
        }
        pathIsEnded = false;

        //direction to the next waypoint
        Vector3 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized;
        //dir *= speed * Time.fixedDeltaTime;

        float dist = Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]);

        //move the AI
        transform.Translate(dir * speed * Time.deltaTime);
        //rb.AddForce(dir, fMode);
        if (dist < nextWaypointDistance)
        {
            currentWaypoint++;
            return;
        }
    }

    //chooses target on spawn
    public void chooseTarget()
    {
        target = Town.transform; 
    }
}

/*
 if(randNum ==1)
 {
    if(Warrior.gameObject.activeInHeirarchy == true)
    {target = Warrior.transform;}
    else
    { target = Town.transform; }
 }

    if(randNum ==2)
 {
    if(Archer.gameObject.activeInHeirarchy == true)
    {target = Archer.transform;} 
    else
    { target = Town.transform; }
 }

    if(randNum ==3)
 {
    if(Mage.gameObject.activeInHeirarchy == true)
    {target = Mage.transform;}
    else
    { target = Town.transform; }
 }

    if(randNum == 4)
 {
    if(Cleric.gameObject.activeInHeirarchy == true)
    {target = Cleric.transform;}
    else
    { target = Town.transform; }
 }

====================================================================================
        if (randNum == 1)
        { target = Town.transform; }

        else if (randNum == 2)
        {
            //----------chooses out of all the characters
            if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true &&
               Cleric.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 5);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Archer.transform; }
                if (secondTarget == 3)
                { target = Mage.transform; }
                if (secondTarget == 4)
                { target = Cleric.transform; }
            }

            //---------chooses out of 3 characters (1/4)
            else if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 4);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Archer.transform; }
                if (secondTarget == 3)
                { target = Mage.transform; }
            }
            //(2/4)
            else if (Cleric.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 4);
                if (secondTarget == 1)
                { target = Cleric.transform; }
                if (secondTarget == 2)
                { target = Archer.transform; }
                if (secondTarget == 3)
                { target = Mage.transform; }
            }
            //(3/4)
            else if (Warrior.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 4);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Cleric.transform; }
                if (secondTarget == 3)
                { target = Mage.transform; }
            }
            //(4/4)
            else if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 4);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Archer.transform; }
                if (secondTarget == 3)
                { target = Cleric.transform; }
            }

            //----------chooses out of 2 players (1/6)
            else if (Warrior.gameObject.activeInHierarchy == true && Archer.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 3);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Archer.transform; }
            }
            //(2/6)
            else if (Warrior.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 3);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Mage.transform; }
            }
            //(3/6)
            else if (Warrior.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 3);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Cleric.transform; }
            }
            //(4/6)
            else if (Archer.gameObject.activeInHierarchy == true && Mage.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 3);
                if (secondTarget == 1)
                { target = Archer.transform; }
                if (secondTarget == 2)
                { target = Mage.transform; }
            }
            //(5/6)
            else if (Archer.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 3);
                if (secondTarget == 1)
                { target = Archer.transform; }
                if (secondTarget == 2)
                { target = Cleric.transform; }
            }
            //(6/6)
            else if (Mage.gameObject.activeInHierarchy == true && Cleric.gameObject.activeInHierarchy == true)
            {
                secondTarget = Random.RandomRange(1, 3);
                if (secondTarget == 1)
                { target = Warrior.transform; }
                if (secondTarget == 2)
                { target = Cleric.transform; }
            }

            //----------chooses out of 1 player
            else if (Warrior.gameObject.activeInHierarchy == true || Archer.gameObject.activeInHierarchy == true || Mage.gameObject.activeInHierarchy == true ||
                     Cleric.gameObject.activeInHierarchy == true)
            {
                if (Warrior.gameObject.activeInHierarchy == true)
                { target = Warrior.transform; }
                if (Archer.gameObject.activeInHierarchy == true)
                { target = Archer.transform; }
                if (Mage.gameObject.activeInHierarchy == true)
                { target = Mage.transform; }
                if (Cleric.gameObject.activeInHierarchy == true)
                { target = Cleric.transform; }
            }

            else
            { target = Town.transform; }
        }
*/
