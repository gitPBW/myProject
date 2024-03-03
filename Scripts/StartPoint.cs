using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPoint : MonoBehaviour
{
    private void Start()
    {
        Scene inGamescene = SceneManager.GetSceneByName("InGame");
        
        if (inGamescene.IsValid())
        {
            GameObject[] objs = inGamescene.GetRootGameObjects();
            foreach (GameObject playobj in objs)
            {
                if (playobj.name == "Player")
                {
                    PlayerController player = playobj.GetComponent<PlayerController>();
                    playobj.transform.position = transform.position;

                    //if (player.bStartpointCheck)
                    //{
                    //    playobj.transform.position = transform.position;
                    //    player.bStartpointCheck = false;
                    //}
                }
            }
        }
    }
}
