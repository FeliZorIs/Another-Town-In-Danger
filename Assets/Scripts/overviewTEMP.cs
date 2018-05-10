using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overviewTEMP : MonoBehaviour {

    Vector2 direction;
    Vector3 zoom;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(direction * speed * Time.deltaTime);
        transform.Translate(zoom * speed * Time.deltaTime);

        direction = Vector2.zero;
        zoom = Vector3.zero;

        // Moving Up, Down, Left, Right, and everything in between

        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;  
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            direction = Vector2.up + Vector2.right;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            direction = Vector2.up + Vector2.left;
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            direction = Vector2.down + Vector2.right;
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            direction = Vector2.down + Vector2.left;
        }

        if (Input.GetKey(KeyCode.E))
        {
            zoom = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            zoom = Vector3.back;
        }
    }
}
