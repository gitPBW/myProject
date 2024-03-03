using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private PlayerController player;
    private void Start()
    {
        //GameObject playObj = GameObject.Find("Player");
        //player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.name.Equals("Player"))
        {
            //DontDestroyOnLoad(collision.gameObject);
            //player.bStartpointCheck = true;
            int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            if(SceneManager.GetActiveScene().name == "Scenes/Stage3")
            {
                SceneManager.LoadScene("Scenes/Stage1");
            }
            else
            {
                SceneManager.LoadScene(CurrentSceneIndex + 1);
            }

            //string currentSceneName = SceneManager.GetActiveScene().name;

            //if(currentSceneName == "Stage3")
            //{
            //    SceneManager.LoadScene("Scenes/Intro");
            //}
            //else
            //{
            //    SceneManager.LoadScene(CurrentSceneIndex + 1);
            //}
        }


        //SceneManager.LoadScene("Scene/IntroScene");
    }
}
