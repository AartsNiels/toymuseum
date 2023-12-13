using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutroManager : MonoBehaviour
{
    public GameObject painting;
    public GameObject CanvasFade;
    public GameObject BlackRoom;
    private bool fadeout = false;

    void Start()
    {
        painting.GetComponent<PaintingMoveBlocks2D>().Active = true;
        CanvasFade.GetComponent<FadeCanvas>().GetComponent<CanvasGroup>().alpha = 0f;
    }

    void Update()
    {
        if (painting.GetComponent<PaintingMoveBlocks2D>().endIntro == true && !fadeout)
        {
            CanvasFade.GetComponent<FadeCanvas>().StartFadeIn();
            fadeout = true;
        }
        if (fadeout)
        {
            if (CanvasFade.GetComponent<FadeCanvas>().GetComponent<CanvasGroup>().alpha == 1f)
            {
                CanvasFade.SetActive(false);
                BlackRoom.SetActive(true);
            }
        }
    }
}
