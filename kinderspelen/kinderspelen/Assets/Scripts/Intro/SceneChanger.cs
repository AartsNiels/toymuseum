using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneName;
    public GameObject fadeCanvas;

    public void ChangeScene()
    {
        fadeCanvas.GetComponent<FadeCanvas>().QuickFadeIn();
        SceneManager.LoadScene(SceneName);
    }
}
