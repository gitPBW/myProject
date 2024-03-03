using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Monster : MonoBehaviour
{
    SpriteRenderer sprite;
    Rigidbody2D rigid;
    Animator animator;

    public LayerMask layermask;

    public float speed;
    public GameObject targetPlay;
    public int nFront = -1; // -1, 0 , 1 
    public float fThinkTime;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        //fFront = Random.Range(-1f, 1f);
        //sprite.flipX = fFront > 0f ? true : false;

        Invoke("AIThink", 3.0f);
        //InvokeRepeating("Direction", 2f, 3f); //처음 2초 후에 불러오고 3초마다 반복
    }

    void FixedUpdate()//물리를 사용할때 쓰는 Update
    {
        rigid.velocity = new Vector2(nFront * speed, rigid.velocity.y);

        //정면 벽 체크;
        RaycastHit2D raycastHit = Physics2D.Raycast(this.transform.position, new Vector2(nFront, 0), 3f, layermask);
        if(raycastHit.collider != null)
        {
            Turn();
            //Debug.Log(raycastHit.collider);
        }

        Debug.DrawRay(this.transform.position, new Vector2(nFront, 0), Color.red);

        //바닥 체크
        raycastHit = Physics2D.Raycast(new Vector2(this.transform.position.x + nFront, this.transform.position.y), Vector2.down, 3f, layermask);
        
        if(raycastHit.collider == null)
        {
            Turn();
            //Debug.Log(raycastHit.collider);
        }
        Debug.DrawRay(new Vector2(this.transform.position.x + nFront, this.transform.position.y), Vector2.down * 3f, Color.blue);
    }

    public void AIThink()
    {
        nFront = Random.Range(-1, 2);

        //fFront *= -1;
        sprite.flipX = nFront > 0f ? true : false;

        animator.SetInteger("Run", nFront);

        fThinkTime = Random.Range(3f, 5f);
        Invoke("AIThink", fThinkTime);
    }

    public void Turn()
    {
        nFront *= -1;
        sprite.flipX = nFront > 0f ? true : false;
        animator.SetInteger("Run", nFront);
    }

}
