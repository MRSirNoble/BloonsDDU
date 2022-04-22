using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public Animator CrossFade;

    private void Update()
    {
       // if (Input.GetMouseButtonDown(0))
            
    }

    public void StartLoad()
    {
        StartCoroutine(LoadNextScene());
    }

    public IEnumerator LoadNextScene()
    {
        CrossFade.gameObject.active = true;
        CrossFade.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        Scene scene = SceneManager.GetActiveScene();
        int nextLevelBuildIndex = 1 - scene.buildIndex;
        SceneManager.LoadScene(nextLevelBuildIndex);
    }
}
