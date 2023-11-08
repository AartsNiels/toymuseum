using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public GameObject painting;
    public float PaintingSpeed = 0.5f;
    public GameObject CanvasFade;

    private float i = 0;
    private float startpos;
    private bool fadeout = false;

    void Start()
    {
        startpos = painting.transform.position.x;
        StartCoroutine(DelayPainting());
    }

    void Update()
    {
        if (painting.active == true)
        {
            if (painting.transform.position.x <= -5)
            {
                i = (Time.time * PaintingSpeed) + startpos;
                painting.transform.position = new Vector3(i, painting.transform.position.y, painting.transform.position.z);
            }
            else
            {
                //Start
                print("Start anim");
            }
        }
        //if (painting.GetComponent<OnTouchVariable>().hitPlayer == true && !fadeout)
        //{
        //   CanvasFade.GetComponent<FadeCanvas>().QuickFadeIn();
        //    fadeout = true;
        //}
        if (fadeout)
        {
            if (CanvasFade.GetComponent<FadeCanvas>().GetComponent<CanvasGroup>().alpha == 1f)
            {
                SceneManager.LoadScene("AnimationPlayer");
            }
        }
    }

    IEnumerator DelayPainting()
    {
        yield return new WaitForSeconds(5);
        painting.SetActive(true);
    }
}
