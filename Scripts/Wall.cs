using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Monster")
        {
            Monster monster = collision.gameObject.GetComponent<Monster>();
            monster.Turn();
        }
    }
}
