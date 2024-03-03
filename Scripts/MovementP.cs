using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP : MonoBehaviour
{
    public SimpleObject Item;
    Animator animator;
    Transform m_transform;
    PlayerController m_PlayerController;
    Rigidbody2D rigid2d;
    SpriteRenderer spriteRenderer;


    //private이지만 유니티에서 보이고 조작가능하게 다른 스크립들은 접근불가능하게
    [SerializeField] private float fSpeed = 5.0f;
    [SerializeField] private float fJumpForce = 5.0f;

    //bool isRunning = false;
    public bool bJumping = false;
    public bool bStartJump = false;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        m_transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        m_PlayerController = GetComponent<PlayerController>();
        rigid2d = GetComponent<Rigidbody2D>();
    }

    public void MoveX(float fvalue)
    {
        bool bRunState = animator.GetBool("Running");

        if(fvalue == 0.0f)
        {
            animator.SetBool("Running",false);
            //isRunning = false;
            return;
        }

        if(bRunState == false)
        {
            animator.SetBool("Running", true);
            //isRunning = true;
        }
        //Vector3 trans = m_transform.localScale;
        //trans.x *= fvalue > 0 ? 1.0f : -1.0f;
        //m_transform.localScale = trans;
        spriteRenderer.flipX = fvalue > 0 ? false : true;



        rigid2d.velocity = new Vector2(fvalue * fSpeed, rigid2d.velocity.y);
    }

    public void MoveY()
    {
        if(bJumping && Mathf.Abs(rigid2d.velocity.y) < 0.00001f)
        {
            bJumping = false;
            rigid2d.gravityScale = 2.0f;
            animator.SetBool("Jumping", bJumping);
        }
    }

    private void FixedUpdate()
    {
        if(bStartJump)
        {
            rigid2d.velocity = Vector2.up * fJumpForce;
            bStartJump = false;
            bJumping = true;
            rigid2d.gravityScale = 1;
            animator.SetBool("Jumping", bJumping);
        }
        MoveY();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            bool bBronze = collision.gameObject.name.Contains("Bronze");
            bool bSilver = collision.gameObject.name.Contains("Silver");
            bool bGold = collision.gameObject.name.Contains("Gold");

            if(bBronze)
            {
                Item.nBronze += 10;
            }
            else if(bSilver)
            {
                Item.nSilver += 10;
            }
            else if(bGold)
            {
                Item.nGold += 10;
            }
        }

        collision.gameObject.SetActive(false);
    }

}
