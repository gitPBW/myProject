using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class TriggerBox : MonoBehaviour
{
    public Monster monster;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //monster.AIThink();
    }
}
