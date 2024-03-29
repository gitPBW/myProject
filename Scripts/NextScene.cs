using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] private string nextScene;
    public void OnClickNextScene()
    {
        SceneManager.LoadScene(nextScene);
        GameObject player = GameObject.Find("Player");
        //SceneManager.LoadScene("Scenes/Stage1", LoadSceneMode.Additive);
        player.GetComponent<PlayerController>().bStartpointCheck = true;
    }

    public void RetryScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
