using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneController : MonoBehaviour
{
    private float progress;
    private void Start()
    {
        StartCoroutine(LoadScene_Coroutine(Global.numScene));
    }
    public IEnumerator LoadScene_Coroutine(int index)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        progress = 1;
        while (!asyncOperation.isDone)
        {
            asyncOperation.allowSceneActivation = false;
            if (progress > 0)
            {
                progress -= Time.deltaTime;
            }
            else if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
