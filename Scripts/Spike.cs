using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float addForce;
    SpriteRenderer sprite;
    GameObject player;
    //int nRepeatCount = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<MovementP>().bJumping == false)
            {
                player = collision.gameObject;
                player.layer = 12;//Damaged

                sprite = player.GetComponent<SpriteRenderer>();
                Rigidbody2D rigid2d = player.GetComponent<Rigidbody2D>();

                sprite.color = new Color(1, 1, 1, 1);
            
                float forceX = (player.transform.position.x - this.transform.position.x) > 0 ? 1f : -1f;
                //Vector2 force = (player.transform.position - this.transform.position).normalized;
                rigid2d.AddForce(new Vector2(forceX, 1) * addForce, ForceMode2D.Impulse);

                //Invoke("Bright", 0.5f);
                //InvokeRepeating("Bright", 0.1f, 0.3f);

                StartCoroutine(Blink());
                Invoke("StopBlinking", 3f);
            }
        }
    }

    public float blinkInterval = 0.1f;
    public bool isBlinking = false;

    IEnumerator Blink()
    {
        isBlinking = true;
        while(isBlinking)
        {
            sprite.color = new Color(1, 1, 1, 0.3f);
            yield return new WaitForSeconds(blinkInterval);

            sprite.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(blinkInterval);
        }
    }
    public void StopBlinking()
    {
        isBlinking = false;
        player.layer = 10;
    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        GameObject player = collision.gameObject;
    //        SpriteRenderer sprite = player.GetComponent<SpriteRenderer>();
    //    }
    //}
    //void Bright()
    //{
    //    sprite.color = new Color(1, 1, 1, 0.3f);

    //    if(nRepeatCount <= 5)
    //    {
    //        sprite.color = new Color(1, 1, 1, 1);
    //        Invoke("Bright", 0.5f);
    //        nRepeatCount++;

    //    }
    //    else
    //    {
    //        sprite.color = new Color(1, 1, 1, 1);
    //        CancelInvoke("Bright");
    //    }

    //    if (player != null)
    //    {
    //        if (nRepeatCount > 5)
    //        {
    //            sprite.color = new Color(1, 1, 1, 1);
    //            player.layer = 10;
    //            CancelInvoke("Bright");
    //        }
    //        else
    //        {

    //            if ((nRepeatCount % 2) == 0)
    //            {
    //                sprite.color = new Color(1, 1, 1, 0.3f);
    //            }
    //            else
    //            {
    //                sprite.color = new Color(1, 1, 1, 1);
    //            }
    //            nRepeatCount++;
    //        }
    //    }
    //}
}
