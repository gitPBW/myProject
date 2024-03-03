using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Camera m_Camera;
    Rigidbody2D m_Rigidbody;
    public float speed = 5.0f;
    public float force = 10.0f;
    Animator m_Animator;
    //PlayerController m_PlayerController;


    // Start is called before the first frame update
    void Start()
    {
        //transform.position = Vector2.zero;
        //m_Rigidbody = GetComponent<Rigidbody2D>();

        //m_Animator = GetComponent<Animator>();

        //m_PlayerController = GetComponent<PlayerController>();

        //m_Animator.SetTrigger("Idle");
        //m_Animator.SetTrigger("Run");
        //m_Animator.SetTrigger("Idle");
        //m_Animator.SetTrigger("Idle");


        //Hierarchy에서 직접 이름을 찾아서 쓰는것.
        //m_Camera = GameObject.Find("Main Camera").GetComponent<Camera>();


        //m_Camera.backgroundColor = Color.white;
    }

    //SpriteRenderer spriteRenderer;

    public void AttackEnd()
    {
        //m_Animator.SetTrigger("Idle");
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        //Debug.Log("X 축 이동거리 :" + x);

        float y = Input.GetAxis("Vertical");
        //Debug.Log("Y 축 이동거리 :" + y);

        if(transform.position.x < -11.3 || transform.position.x > 11.3 )
        {
            Destroy(this.gameObject);
            return;
        }

        if(x >= 0.1 )
        {
            m_Animator.SetTrigger("Run");
        }

        else
        {
            m_Animator.SetTrigger("Idle");
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.SetTrigger("Attack");
        }
        //else if(Input.GetKeyUp(KeyCode.Space))
        //{
        //    m_Animator.SetTrigger("Idle");
        //}

        Vector2 movement = new Vector2(x, y);
        movement.Normalize();

        float vforce = m_Rigidbody.mass * force;

        //입력한 것만큼 이동하는 움직임
        //m_Rigidbody.velocity = speed * movement;

        //힘을 가해서 미끄러지는듯한 움직임
        //m_Rigidbody.AddForce(movement * vforce);

        //transform.position += movement;
        //transform.Translate(movement);
    }
}
