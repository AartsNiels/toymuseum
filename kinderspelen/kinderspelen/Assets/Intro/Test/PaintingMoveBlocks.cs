using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PaintingMoveBlocks : MonoBehaviour
{
    public bool Active = false;

    public List<GameObject> blocks;

    private bool delay = false;



    void Start()
    {
        for (int i = 0; i < blocks.Count; i++)
        {
            print(blocks[i].transform.position.x);
        }
    }

    void Update()
    {
       if (Active && !delay)
       {
            for (int i = 0; i < blocks.Count; i++)
            {
                blocks[i].transform.localScale = new Vector3(Random.Range(0.5f, 20f), 0.5f, 0.5f);
                StartCoroutine(DelayPainting());
                delay = true;
            }

        }
    }

    IEnumerator DelayPainting()
    {
        yield return new WaitForSeconds(2);
        delay = false;
    }
}
