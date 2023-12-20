using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PaintingMoveBlocks : MonoBehaviour
{
    public bool Active = false;
    public List<GameObject> blocks;
    public bool endIntro = false;

    private bool delay = false;
    private float DelayTime = 0.3f;
    private int iterations = 0;
    private int MaxLength = 30;

    void Update()
    {
       if (Active && !delay)
       {
            for (int i = 0; i < blocks.Count; i++)
            {
                blocks[i].transform.localScale = new Vector3(Random.Range(0.5f, MaxLength), 0.5f, 0.5f);
                StartCoroutine(DelayPainting());
                delay = true;
                iterations += 1;
            }
            else if(iterations / 4 == 16)
            {
                DelayTime = 0.1f;
                MaxLength = 50;
            }
            else if(iterations / 4 == 35)
            {
                endIntro = true;
            }
        }
    }

    IEnumerator DelayPainting()
    {
        yield return new WaitForSeconds(DelayTime);
        delay = false;
    }
}
