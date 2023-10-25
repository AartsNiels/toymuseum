using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeigt : MonoBehaviour
{
    public GameObject xrOrigin;
    public int height = 4;

    public void changeHeight()
    {
        xrOrigin.transform.position = new Vector3(xrOrigin.transform.position.x, xrOrigin.transform.position.y + height, xrOrigin.transform.position.z);
    }

    public void resetHeight()
    {
        xrOrigin.transform.position = new Vector3(xrOrigin.transform.position.x, xrOrigin.transform.position.y - height, xrOrigin.transform.position.z);
    }
}
