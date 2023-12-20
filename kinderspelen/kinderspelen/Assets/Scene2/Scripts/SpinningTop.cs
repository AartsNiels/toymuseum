using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpinningTop : MonoBehaviour
{
    public float spinSpeed = 5f; // De snelheid waarmee de tol draait
    public float stability = 1.0f; // De mate van stabiliteit van de tol
    public PhysicMaterial frictionMaterial; // Fysiek materiaal voor wrijving

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Voeg een kleine initiële impuls toe om de tol te starten
        rb.AddForce(transform.up * stability, ForceMode.Impulse);

        // Gebruik een cilinder collider voor stabiliteit
        GetComponent<Collider>().isTrigger = false;

        // Pas de massa van de tol aan
        rb.mass = 1.0f;

        // Pas de zwaartekracht aan
        Physics.gravity = new Vector3(0, -9.81f, 0);

        // Voeg een fysiek materiaal toe voor wrijving
        GetComponent<Collider>().material = frictionMaterial;
    }

    void Update()
    {
        // Laat de tol rond zijn eigen as draaien
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
