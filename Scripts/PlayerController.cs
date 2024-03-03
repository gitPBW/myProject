using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    MovementP playerMove;
    Animator animator;
   
    public bool bStartpointCheck;
    void Start()
    {
        playerMove = GetComponent<MovementP>();
        animator = GetComponent<Animator>();
        GameObject.Find("Player").SetActive(true);
    }

    private void OnEnable()
    {
        //transform.position = GameObject.Find("StartPos").transform.position;
        bStartpointCheck = false;

        //Variables variables = GameObject.Find("VisualScripting SceneVariables").GetComponent<Variables>();
        //variables.

        //Scene inGamescene = SceneManager.GetSceneByName("InGame");
        //if(inGamescene.IsValid())
        //{
        //    Scene stage1 = SceneManager.GetSceneByName("Stage1");
        //    Scene stage2 = SceneManager.GetSceneByName("Stage2");
        //    Scene stage3 = SceneManager.GetSceneByName("Stage3");

        //    Scene currentStage = inGamescene;
        //    if(stage1.IsValid())
        //    {
        //        currentStage = stage1;
        //    }
        //    else if (stage2.IsValid())
        //    {
        //        currentStage = stage2;
        //    }
        //    else if (stage3.IsValid())
        //    {
        //        currentStage = stage3;
        //    }

        //    if (currentStage.IsValid())
        //    {
        //        GameObject[] objs = currentStage.GetRootGameObjects();
        //        foreach(GameObject item in objs)
        //        {
        //            if(item.name.Equals("StartPos"))
        //            {
        //                transform.position = item.transform.position;
        //            }
        //        }
        //    }
        //}
    }

    void Update()
    {
        Moveing();
        Jumping();
        Slide();
        Attack();
    }

    void Moveing()
    {
        float x = Input.GetAxis("Horizontal");
        playerMove.MoveX(x);
    }
    void Jumping()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
             playerMove.bStartJump = true;
            //playerMove.MoveY();
        }
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    playerMove.bJumping = true;
        //}
        //else if(Input.GetKeyUp(KeyCode.Space))
        //{
        //    playerMove.bJumping = false;
        //}
    }

    void Slide()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            animator.Play("Slide");
            //playerMove.MoveX(1);
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.Play("Attack");
        }
    }

    public void JumpAttack()
    {
        Debug.Log("점프 어택");
    }
}
