using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    //public GameObject Box;
    //public GameObject Capsule;
    //public GameObject Circle;
    //public GameObject Triangle;

    public GameObject[] gameObjs;

    // Start is called before the first frame update
    void Start()
    {
        //积己 矫难林绰 Instantiate
        //Instantiate(Box, new Vector3(1, 1, 0), Quaternion.identity);
        //Instantiate(Capsule, new Vector3(2, 2, 0), Quaternion.Euler(0, 0, 90));
        //Instantiate(Circle, new Vector3(3, 3, 0), Quaternion.identity);
        //Instantiate(Triangle, new Vector3(4, 4, 0), Quaternion.identity);

        for(int i = 0; i < gameObjs.Length; ++i)
        {
            Instantiate(gameObjs[i], new Vector3(i, i, 0), Quaternion.identity);
        }



        //Quaternion.Euler()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
