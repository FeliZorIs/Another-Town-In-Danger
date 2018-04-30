using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2AsP3 : MonoBehaviour {
    private Rigidbody2D rb2d;
    private Animator anim;
    public float speed;
    private Vector2 direction;
    public bool isDead;

    private float DirX;
    private float DirY;

    int WalkUp = Animator.StringToHash("Base Layer.Player2_Walk_Up");
    int IdleUp = Animator.StringToHash("Base Layer.Player2_Idle_up");

    int WalkDown = Animator.StringToHash("Base Layer.Player2_Walk_Down");
    int IdleDown = Animator.StringToHash("Base Layer.Player2_Idle_Down");

    int WalkLeft = Animator.StringToHash("Base Layer.Player2_Walk_Left");
    int IdleLeft = Animator.StringToHash("Base Layer.Player2_Idle_Left");

    int WalkRight = Animator.StringToHash("Base Layer.Player2_Walk_Right");
    int IdleRight = Animator.StringToHash("Base Layer.Player2_Idle_Right");

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
        DirX = Input.GetAxis("Dir X") * speed;
        DirY = Input.GetAxis("Dir Y") * speed;
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

            if (DirY > 0.2f)
            {
                direction = Vector2.up;
                anim.SetBool("Walking_up", true);

            }

            if (DirX < -.2f)
            {
                direction = Vector2.left;
                anim.SetBool("Walking_left", true);
            }

            if (DirY < -.2f)
            {
                direction = Vector2.down;
                anim.SetBool("Walking_down", true);
            }

            if (DirX > .2f)
            {
                direction = Vector2.right;
                anim.SetBool("Walking_right", true);
            }

            if (DirY > 0.2f && DirX > .2f)
            {
                direction = Vector2.up + Vector2.right;
            }

            if (DirY > 0.2f && DirX < -.2f)
            {
                direction = Vector2.up + Vector2.left;
            }

            if (DirY < -.2f && DirX > .2f)
            {
                direction = Vector2.down + Vector2.right;
            }

            if (DirY < -.2f && DirX < -.2f)
            {
                direction = Vector2.down + Vector2.left;
            }

            // Attacking Animations
            //
            AnimatorStateInfo StateInfo = anim.GetCurrentAnimatorStateInfo(0);

            if (Input.GetKeyDown(KeyCode.Joystick1Button2))
            {

                if (StateInfo.nameHash == WalkUp || StateInfo.nameHash == IdleUp)
                {
                    anim.SetTrigger("Attack2_up");
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
