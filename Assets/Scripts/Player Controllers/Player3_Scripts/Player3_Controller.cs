using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3_Controller : MonoBehaviour {

    private Rigidbody2D rb2d;
    private Animator anim;
    public float speed;
    private Vector2 direction;
    public bool isDead;

    int WalkUp = Animator.StringToHash("Base Layer.Player3_Walking_Up");
    int IdleUp = Animator.StringToHash("Base Layer.PLayer3_Idle_Up");

    int WalkDown = Animator.StringToHash("Base Layer.Player3_Walking_Down");
    int IdleDown = Animator.StringToHash("Base Layer.Player3_Idle_Down");

    int WalkLeft = Animator.StringToHash("Base Layer.Player3_Walking_Left");
    int IdleLeft = Animator.StringToHash("Base Layer.Player3_Idle_Left");

    int WalkRight = Animator.StringToHash("Base Layer.Player3_Walking_Right");
    int IdleRight = Animator.StringToHash("Base Layer.Player3_Idle_Right");

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        isDead = false;
    }

    // Movement
    void FixedUpdate()
    {
        Inputs();
        Movement();
    }

    /*-------------------------------------------------------------------------------------------
                                       Functions
    ---------------------------------------------------------------------------------------------*/

    private void Movement()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Inputs()
    {
        if (isDead == false)
        {
            direction = Vector2.zero;
            anim.SetBool("Walking_right", false);
            anim.SetBool("Walking_left", false);
            anim.SetBool("Walking_up", false);
            anim.SetBool("Walking_down", false);

            // Moving Up, Down, Left, Right, and everything in between

            if (Input.GetKey(KeyCode.W))
            {
                direction = Vector2.up;
                anim.SetBool("Walking_up", true);
            }

            if (Input.GetKey(KeyCode.A))
            {
                direction = Vector2.left;
                anim.SetBool("Walking_left", true);
            }

            if (Input.GetKey(KeyCode.S))
            {
                direction = Vector2.down;
                anim.SetBool("Walking_down", true);
            }

            if (Input.GetKey(KeyCode.D))
            {
                direction = Vector2.right;
                anim.SetBool("Walking_right", true);
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

            // Attacking Animations

            if (Input.GetKeyDown(KeyCode.F))
            {
                AnimatorStateInfo StateInfo = anim.GetCurrentAnimatorStateInfo(0);

                if (StateInfo.nameHash == WalkUp || StateInfo.nameHash == IdleUp)
                {
                    anim.SetTrigger("Attack_up");
                }

                if (StateInfo.nameHash == WalkDown || StateInfo.nameHash == IdleDown)
                {
                    anim.SetTrigger("Attack_down");
                }

                if (StateInfo.nameHash == WalkLeft || StateInfo.nameHash == IdleLeft)
                {
                    anim.SetTrigger("Attack_left");
                }

                if (StateInfo.nameHash == WalkRight || StateInfo.nameHash == IdleRight)
                {
                    anim.SetTrigger("Attack_right");
                }
            }
        }

        else
        {
            return;
        }
    }
}
