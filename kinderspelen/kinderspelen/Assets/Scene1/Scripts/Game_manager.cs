using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour
{
    public GameObject CanvasFade;
    private bool fadeout = false;
    public string Scene = "";

    void Start()
    {
        CanvasFade.GetComponent<FadeCanvas>().StartFadeOut();
    }

    void Update()
    {
        if (fadeout)
        {
            if (CanvasFade.GetComponent<FadeCanvas>().GetComponent<CanvasGroup>().alpha == 1f)
            {
                SceneManager.LoadScene(Scene);
            }
        }
    }
}
