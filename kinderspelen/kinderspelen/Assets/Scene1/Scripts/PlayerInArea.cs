using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInArea : MonoBehaviour
{
    private bool PlayerInZone;                  //check if the player is in trigger
    public string AnimationToPlayName;          // Variabele om de naam van de animatie in te stellen

    private void Start()
    {
        PlayerInZone = false;                   //player not in zone       
    }

    private void Update()
    {
        if (PlayerInZone)           //if in zone
        {
            Debug.Log("test");
            gameObject.GetComponent<Animator>().Play(AnimationToPlayName);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            Debug.Log("test");
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
        }
    }
}
