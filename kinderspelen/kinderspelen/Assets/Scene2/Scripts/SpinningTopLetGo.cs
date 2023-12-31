using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningTopLetGo : MonoBehaviour
{
    private bool isHeld = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Als de linkermuisknop wordt ingedrukt, houd de tol vast
            isHeld = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            // Als de linkermuisknop wordt losgelaten, laat de tol los en laat deze draaien
            isHeld = false;
            SpinTop();
        }

        if (isHeld)
        {
            // Als de tol wordt vastgehouden, beweeg deze met de muispositie
            MoveWithMouse();
        }
    }

    void SpinTop()
    {
        // Voeg een willekeurige draaisnelheid toe wanneer de tol wordt losgelaten
        Vector3 randomTorque = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        rb.AddTorque(randomTorque, ForceMode.Impulse);
    }

    void MoveWithMouse()
    {
        // Laat de tol de muispositie volgen in het horizontale vlak
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(targetPosition);
        }
    }
}