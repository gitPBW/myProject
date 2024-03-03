using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataResource : MonoBehaviour
{
    [SerializeField]
    public SimpleObject Item;
    
    //static public int nGold
    //{
    //    set { nGold = value; }
    //    get { return nGold; }
    //}
    //static public int nGem
    //{
    //    set { nGem = value; }
    //    get { return nGem; }
    //}
    //static public int nFood
    //{
    //    set { nFood = value; }
    //    get { return nFood; }
    //}

    //public int nGem;
    //public int nGold;
    //public int nFood;

    private void Awake()
    {
        //nGem = 0;
        //nGold = 0;
        //nFood = 0;

    }

}
