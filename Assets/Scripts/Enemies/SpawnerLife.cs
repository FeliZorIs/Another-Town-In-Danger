using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLife : MonoBehaviour {

    public Animator anim;
    public bool destroyed = false;

    GameObject player;
    Animator P_anim;

    // Player1 states
    int AttackUp = Animator.StringToHash("Base Layer.Player_Attack_Up");
    int AttackDown = Animator.StringToHash("Base Layer.Player_Attack_Down");
    int AttackLeft = Animator.StringToHash("Base Layer.Player_Attack_Left");
    int AttackRight = Animator.StringToHash("Base Layer.Player_Attack_Right");

    // Player 2 states
    int AttackUp2 = Animator.StringToHash("Base Layer.Player2_Attack_Up");
    int AttackDown2 = Animator.StringToHash("Base Layer.Player2_Attack_Down");
    int AttackLeft2 = Animator.StringToHash("Base Layer.Player2_Attack_Left");
    int AttackRight2 = Animator.StringToHash("Base Layer.Player2_Attack_Right");

    // Player 3 states
    int AttackUp3 = Animator.StringToHash("Base Layer.Player3_Attack_Up");
    int AttackDown3 = Animator.StringToHash("Base Layer.Player3_Attack_Down");
    int AttackLeft3 = Animator.StringToHash("Base Layer.Player3_Attack_Left");
    int AttackRight3 = Animator.StringToHash("Base Layer.Player3_Attack_Right");

    // Player 4 states
    int AttackUp4 = Animator.StringToHash("Base Layer.Player4_Attack_Up");
    int AttackDown4 = Animator.StringToHash("Base Layer.Player4_Attack_Down");
    int AttackLeft4 = Animator.StringToHash("Base Layer.Player4_Attack_Left");
    int AttackRight4 = Animator.StringToHash("Base Layer.Player4_Attack_Right");


    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;
            P_anim = player.GetComponent<Animator>();
            AnimatorStateInfo StateInfo = P_anim.GetCurrentAnimatorStateInfo(0);

            // Player 1 collision assessments
            if (StateInfo.nameHash == AttackUp || StateInfo.nameHash == AttackDown || StateInfo.nameHash == AttackLeft || StateInfo.nameHash == AttackRight)
            {
                anim.SetTrigger("Destroyed");
                this.GetComponent<EnemySpawn>().enabled = false;
                destroyed = true;
            }

            // Player 2 collision assessments
            if (StateInfo.nameHash == AttackUp2 || StateInfo.nameHash == AttackDown2 || StateInfo.nameHash == AttackLeft2 || StateInfo.nameHash == AttackRight2)
            {
                anim.SetTrigger("Destroyed");
                this.GetComponent<EnemySpawn>().enabled = false;
                destroyed = true;
            }

            // Player 3 collision assessments
            if (StateInfo.nameHash == AttackUp3 || StateInfo.nameHash == AttackDown3 || StateInfo.nameHash == AttackLeft3 || StateInfo.nameHash == AttackRight3)
            {
                anim.SetTrigger("Destroyed");
                this.GetComponent<EnemySpawn>().enabled = false;
                destroyed = true;
            }

            // Player 4 collision assessments
            if (StateInfo.nameHash == AttackUp4 || StateInfo.nameHash == AttackDown4 || StateInfo.nameHash == AttackLeft4 || StateInfo.nameHash == AttackRight4)
            {
                anim.SetTrigger("Destroyed");
                this.GetComponent<EnemySpawn>().enabled = false;
                destroyed = true;
            }
        }
                
    }
}
