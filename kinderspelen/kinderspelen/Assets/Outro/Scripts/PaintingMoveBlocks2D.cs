using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingMoveBlocks2D : MonoBehaviour
{
    public bool Active = false;
    public List<GameObject> blocks;
    public float MoveSpeed = 0.5f;
    public bool endIntro = false;

    private bool Delay = false;
    private float Movement = 0.01f;

    void Start()
    {
        blocks[0].transform.localPosition = new Vector3(0f, 1f, -1.25f);    //LB
        blocks[1].transform.localPosition = new Vector3(0f, 1f, 1.25f);    //RB

        blocks[2].transform.localPosition = new Vector3(0f, -0.25f, -1.25f);    //LO
        blocks[3].transform.localPosition = new Vector3(0f, -0.25f, 1.25f);    //RO
    }

    void Update()
    {
        if (Active && !Delay)
        {
            StartCoroutine(DelayPainting());
            Delay = true;

            if (blocks[3].transform.localPosition.z > 0.26f)
            {
                blocks[0].transform.localPosition = new Vector3(0f, blocks[0].transform.localPosition.y - 0.0075f, blocks[0].transform.localPosition.z + Movement);    //LB
                blocks[1].transform.localPosition = new Vector3(0f, blocks[1].transform.localPosition.y - 0.0075f, blocks[1].transform.localPosition.z - Movement);    //RB
                blocks[2].transform.localPosition = new Vector3(0f, -0.25f, blocks[2].transform.localPosition.z + Movement);    //LO
                blocks[3].transform.localPosition = new Vector3(0f, -0.25f, blocks[3].transform.localPosition.z - Movement);    //RO
            }
            else
            {
                endIntro = true;
            }
        }
    }

    IEnumerator DelayPainting()
    {
        yield return new WaitForSeconds(MoveSpeed);
        Delay = false;
    }
}
