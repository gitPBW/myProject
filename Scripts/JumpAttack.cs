using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAttack : MonoBehaviour
{
    //public GameObject playerObj;
    //public PlayerController playercontroller;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            if (this.GetComponent<MovementP>().bJumping) //&& (this.transform.position.y - collision.transform.position.y) > 0.01f)
            {
                collision.gameObject.layer = 12;
                collision.gameObject.GetComponent<SpriteRenderer>().flipY = true;
                collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 7);
            }

            ////플레이어 위치가 몬스터 위치봐다 위에 있을때
            //if(this.transform.position.y > collision.transform.position.y)
            //{
            //    SpriteRenderer monster = collision.gameObject.GetComponent<SpriteRenderer>();
            //    Rigidbody2D monsterrigid = collision.gameObject.GetComponent<Rigidbody2D>();
                
            //    monster.flipY = true;
            //    monsterrigid.AddForce(Vector2.up * 5f);
            //    //Destroy(collision.gameObject, 2.0f);
            //}
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            collision.gameObject.layer = 9;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;

            //collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5);
        }
    }
}
