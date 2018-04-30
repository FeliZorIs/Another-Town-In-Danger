using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

[RequireComponent (typeof (Rigidbody2D))]
[RequireComponent(typeof(Seeker))]
public class EnemyAI : MonoBehaviour {

    //target to chase
    public Transform target;

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

    private void Start()
    {
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
            //TODO: insert a player search here
            yield return false;
        }
        seeker.StartPath(transform.position, target.position, OnPathComplete);
        yield return new WaitForSeconds(1f / updateRate);
        StartCoroutine(UpdatePath());
    }

    public void OnPathComplete(Path p)
    {
        Debug.Log("We got a path. Did it have an error?" + p.error);
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
        dir *= speed * Time.fixedDeltaTime;

        float dist = Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]);
        //move the AI
        rb.AddForce(dir, fMode);
        if (dist < nextWaypointDistance)
        {
            currentWaypoint++;
            return;
        }
    }
}
