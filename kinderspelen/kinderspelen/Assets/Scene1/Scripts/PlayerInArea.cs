using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInArea : MonoBehaviour
{
    public GameObject uiElement; // Referentie naar het UI-element dat je wilt tonen

    private bool PlayerInZone; // Check of de speler in de trigger is

    private void Start()
    {
        PlayerInZone = false; // Speler niet in de zone       
        uiElement.SetActive(false); // Zorg ervoor dat het UI-element in het begin verborgen is
    }

    private void Update()
    {
        if (PlayerInZone)
        {
            // Als de speler in de zone is, toon dan het UI-element
            uiElement.SetActive(true);
        }
        else
        {
            // Als de speler niet in de zone is, verberg het UI-element
            uiElement.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // Als de speler in de zone is
        {
            PlayerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") // Als de speler de zone verlaat
        {
            PlayerInZone = false;
        }
    }
}
