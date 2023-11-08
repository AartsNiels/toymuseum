using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchVariable : MonoBehaviour
{
    public bool hitPlayer = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            hitPlayer = true;
            gameObject.SetActive(!hitPlayer);
        }
    }
}
