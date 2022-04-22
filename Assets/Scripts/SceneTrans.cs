using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    GameObject overlay;

    public void LoadScene(string sceneName)
    {
        overlay.active = true;
        overlay.GetComponent<Animator>().SetTrigger("Fade");
        //SceneManager.LoadScene(sceneName);
    }
}
