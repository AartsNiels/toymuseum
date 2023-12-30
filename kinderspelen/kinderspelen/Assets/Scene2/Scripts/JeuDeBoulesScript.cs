using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeuDeBoulesScript : MonoBehaviour
{
    public float winDistance = 2f; // Afstand om te winnen
    public LayerMask targetLayer; // Laag van de objecten waarmee de afstand wordt gecontroleerd

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Voorbeeld: Check wanneer de linkermuisknop wordt ingedrukt
        {
            CheckWin();
        }
    }

    void CheckWin()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target"); // Vervang "Target" door de tag van de objecten waarmee je de afstand wilt controleren

        Transform playerTransform = transform; // Transform van de speler

        GameObject closestTarget = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject target in targets)
        {
            float distance = Vector3.Distance(playerTransform.position, target.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestTarget = target;
            }
        }

        if (closestTarget != null && closestDistance < winDistance)
        {
            Debug.Log("Speler wint! Het dichtstbijzijnde object is: " + closestTarget.name);
            // Voeg hier verdere acties toe die moeten plaatsvinden wanneer de speler wint
        }
        else
        {
            Debug.Log("Geen winnaar. Probeer opnieuw!");
        }
    }
}

