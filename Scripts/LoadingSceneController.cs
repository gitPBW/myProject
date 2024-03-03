using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadingSceneController : MonoBehaviour
{
    [SerializeField] 
    private Image progressBar;
    [SerializeField]
    CanvasGroup canvasGroup;
    [SerializeField]
    private string loadingScene;
    [SerializeField]
    private GameObject player;


    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        //SceneManager.LoadScene("Scenes/Stage1");
        StartCoroutine(LoadSceneProgress());
        //DontDestroyOnLoad(player);
        //player.SetActive(false);

    }

    //public void LoadingScene(string sceneName)
    //{
    //    SceneManager.sceneLoaded += OnSceneLoaded;
    //    loadingScene = sceneName;
    //    StartCoroutine(LoadSceneProgress());
    //}

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if(arg0.name == loadingScene)
        {
            //Debug.Log(arg0.name);
            SceneManager.sceneLoaded -= OnSceneLoaded;
            StopCoroutine(LoadSceneProgress());
            

        }
        return;
    }


    private IEnumerator LoadSceneProgress()
    {
        progressBar.fillAmount = 0;
        yield return null;

        AsyncOperation op = SceneManager.LoadSceneAsync(loadingScene);
        op.allowSceneActivation = false;

        float timer = 0.0f;

        while (!op.isDone)
        {
            yield return null;

            if(op.progress < 0.9f)
            {
                progressBar.fillAmount = op.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                progressBar.fillAmount = Mathf.Lerp(0.9f, 1f, timer);
                if (progressBar.fillAmount >= 1.0f)
                {
                    op.allowSceneActivation = true;
                    //player.SetActive(true);
                    //player.GetComponent<PlayerController>().bStartpointCheck = true;
                    yield break;
                }
            }
        }
    }
}
