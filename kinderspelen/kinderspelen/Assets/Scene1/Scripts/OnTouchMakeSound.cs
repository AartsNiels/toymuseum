using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTouchMakeSound : MonoBehaviour
{
    public AudioClip Sound; // Geluid dat afgespeeld moet worden

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Stick")
        {
            AudioSource.PlayClipAtPoint(Sound, transform.position);
        }
    }
}
