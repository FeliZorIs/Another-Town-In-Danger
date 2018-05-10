using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour {

    GameObject player;
    Animator anim;

    // Player1 states
    int AttackUp = Animator.StringToHash("Base Layer.Player_Attack_Up");
    int AttackDown = Animator.StringToHash("Base Layer.Player_Attack_Down");
    int AttackLeft = Animator.StringToHash("Base Layer.Player_Attack_Left");
    int AttackRight = Animator.StringToHash("Base Layer.Player_Attack_Right");
    int MoveUp = Animator.StringToHash("Base Layer.Player_Idle_Up");
    int MoveDown = Animator.StringToHash("Base Layer.Player_Idle_Down");
    int MoveLeft = Animator.StringToHash("Base Layer.Player_Idle_Left");
    int MoveRight = Animator.StringToHash("Base Layer.Player_Idle_Right");
    int IdleUp = Animator.StringToHash("Base Layer.Player_Walk_Up");
    int IdleDown = Animator.StringToHash("Base Layer.Player_Walk_Down");
    int IdleLeft = Animator.StringToHash("Base Layer.Player_Walk_Left");
    int IdleRight = Animator.StringToHash("Base Layer.Player_Walk_Right");

    // Player 2 states
    int AttackUp2 = Animator.StringToHash("Base Layer.Player2_Attack_Up");
    int AttackDown2 = Animator.StringToHash("Base Layer.Player2_Attack_Down");
    int AttackLeft2 = Animator.StringToHash("Base Layer.Player2_Attack_Left");
    int AttackRight2 = Animator.StringToHash("Base Layer.Player2_Attack_Right");
    int MoveUp2 = Animator.StringToHash("Base Layer.Player2_Idle_up");
    int MoveDown2 = Animator.StringToHash("Base Layer.Player2_Idle_Down");
    int MoveLeft2 = Animator.StringToHash("Base Layer.Player2_Idle_Left");
    int MoveRight2 = Animator.StringToHash("Base Layer.Player2_Idle_Right");
    int IdleUp2 = Animator.StringToHash("Base Layer.Player2_Walk_Up");
    int IdleDown2 = Animator.StringToHash("Base Layer.Player2_Walk_Down");
    int IdleLeft2 = Animator.StringToHash("Base Layer.Player2_Walk_Left");
    int IdleRight2 = Animator.StringToHash("Base Layer.Player2_Walk_Right");

    // Player 3 states
    int AttackUp3 = Animator.StringToHash("Base Layer.Player3_Attack_Up");
    int AttackDown3 = Animator.StringToHash("Base Layer.Player3_Attack_Down");
    int AttackLeft3 = Animator.StringToHash("Base Layer.Player3_Attack_Left");
    int AttackRight3 = Animator.StringToHash("Base Layer.Player3_Attack_Right");
    int MoveUp3 = Animator.StringToHash("Base Layer.PLayer3_Idle_up");
    int MoveDown3 = Animator.StringToHash("Base Layer.Player3_Idle_Down");
    int MoveLeft3 = Animator.StringToHash("Base Layer.Player3_Idle_Left");
    int MoveRight3 = Animator.StringToHash("Base Layer.Player3_Idle_Right");
    int IdleUp3 = Animator.StringToHash("Base Layer.Player3_Walking_Up");
    int IdleDown3 = Animator.StringToHash("Base Layer.Player3_Walking_Down");
    int IdleLeft3 = Animator.StringToHash("Base Layer.Player3_Walking_Left");
    int IdleRight3 = Animator.StringToHash("Base Layer.Player3_Walking_Right");

    // Player 4 states
    int AttackUp4 = Animator.StringToHash("Base Layer.Player4_Attack_Up");
    int AttackDown4 = Animator.StringToHash("Base Layer.Player4_Attack_Down");
    int AttackLeft4 = Animator.StringToHash("Base Layer.Player4_Attack_Left");
    int AttackRight4 = Animator.StringToHash("Base Layer.Player4_Attack_Right");
    int MoveUp4 = Animator.StringToHash("Base Layer.Player4_Idle_up");
    int MoveDown4 = Animator.StringToHash("Base Layer.Player4_Idle_Down");
    int MoveLeft4 = Animator.StringToHash("Base Layer.Player4_Idle_Left");
    int MoveRight4 = Animator.StringToHash("Base Layer.Player4_Idle_Right");
    int IdleUp4 = Animator.StringToHash("Base Layer.Player4_Walking_Up");
    int IdleDown4 = Animator.StringToHash("Base Layer.Player4_Walking_Down");
    int IdleLeft4 = Animator.StringToHash("Base Layer.Player4_Walking_Left");
    int IdleRight4 = Animator.StringToHash("Base Layer.Player4_Walking_Right");

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            anim = player.GetComponent<Animator>();
            AnimatorStateInfo StateInfo = anim.GetCurrentAnimatorStateInfo(0);

            // Player 1 collision assessments
            if (StateInfo.nameHash == AttackUp || StateInfo.nameHash == AttackDown || StateInfo.nameHash == AttackLeft || StateInfo.nameHash == AttackRight)
            {
                Debug.Log("I've been impaled");
            }
            if (StateInfo.nameHash == MoveUp || StateInfo.nameHash == MoveDown || StateInfo.nameHash == MoveLeft || StateInfo.nameHash == MoveRight ||
                StateInfo.nameHash == IdleUp || StateInfo.nameHash == IdleDown || StateInfo.nameHash == IdleLeft || StateInfo.nameHash == IdleRight)
            {
                player.GetComponent<Players_Health>().health -= 1;
                Debug.Log("Hah, poked!");
            }

            // Player 2 collision assessments
            if (StateInfo.nameHash == AttackUp2 || StateInfo.nameHash == AttackDown2 || StateInfo.nameHash == AttackLeft2 || StateInfo.nameHash == AttackRight2)
            {
                Debug.Log("I've been impaled");
            }
            if (StateInfo.nameHash == MoveUp2 || StateInfo.nameHash == MoveDown2 || StateInfo.nameHash == MoveLeft2 || StateInfo.nameHash == MoveRight2 ||
                StateInfo.nameHash == IdleUp2 || StateInfo.nameHash == IdleDown2 || StateInfo.nameHash == IdleLeft2 || StateInfo.nameHash == IdleRight2)
            {
                player.GetComponent<Players_Health>().health -= 1;
                Debug.Log("Hah, poked!");
            }

            // Player 3 collision assessments
            if (StateInfo.nameHash == AttackUp3 || StateInfo.nameHash == AttackDown3 || StateInfo.nameHash == AttackLeft3 || StateInfo.nameHash == AttackRight3)
            {
                Debug.Log("I've been impaled");
            }
            if (StateInfo.nameHash == MoveUp3 || StateInfo.nameHash == MoveDown3 || StateInfo.nameHash == MoveLeft3 || StateInfo.nameHash == MoveRight3 ||
                StateInfo.nameHash == IdleUp3 || StateInfo.nameHash == IdleDown3 || StateInfo.nameHash == IdleLeft3 || StateInfo.nameHash == IdleRight3)
            {
                player.GetComponent<Players_Health>().health -= 1;
                Debug.Log("Hah, poked!");
            }

            // Player 4 collision assessments
            if (StateInfo.nameHash == AttackUp4 || StateInfo.nameHash == AttackDown4 || StateInfo.nameHash == AttackLeft4 || StateInfo.nameHash == AttackRight4)
            {
                Debug.Log("I've been impaled");
            }
            if (StateInfo.nameHash == MoveUp4 || StateInfo.nameHash == MoveDown4 || StateInfo.nameHash == MoveLeft4 || StateInfo.nameHash == MoveRight4 ||
                StateInfo.nameHash == IdleUp4 || StateInfo.nameHash == IdleDown4 || StateInfo.nameHash == IdleLeft4 || StateInfo.nameHash == IdleRight4)
            {
                player.GetComponent<Players_Health>().health -= 1;
                Debug.Log("Hah, poked!");
            }
        }
    }

    //When enemy touches the town, it dies
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Town")
        {
            Destroy(this.gameObject);
        }
    }
}
