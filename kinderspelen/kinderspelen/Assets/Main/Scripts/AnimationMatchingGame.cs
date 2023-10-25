using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class AnimationMatchingGame : MonoBehaviour
{
    public GameObject[] animationObjects;
    public GameObject[] correctBlocks;
    public float animationDuration = 2f;
    public int pointsPerCorrectMatch = 1;
    public float delayBeforeNextAnimation = 5f;

    private int currentAnimationIndex = 0;
    private int score = 0;
    private bool isAnimating = false;

    private void Start()
    {
        NextAnimation();
    }

    private void Update()
    {
        if (isAnimating) return;

        if (currentAnimationIndex < animationObjects.Length)
        {
            // Wacht op de gebruiker om de juiste kubus vast te pakken
            if (IsMatched() && Input.GetMouseButtonDown(0)) // Verander naar de juiste invoer voor jouw XR-interactie.
            {
                score += pointsPerCorrectMatch;
                Debug.Log("Goed gedaan! Score: " + score);

                // Schakel de animatie uit
                animationObjects[currentAnimationIndex].SetActive(false);
                isAnimating = false;

                NextAnimation();
            }
            else
            {
                Debug.Log("Fout! Probeer opnieuw.");
            }
        }
        else
        {
            Debug.Log("Het spel is afgelopen. Eindscore: " + score);
        }
    }

    private bool IsMatched()
    {
        return correctBlocks[currentAnimationIndex].activeSelf;
    }

    private void NextAnimation()
    {
        if (currentAnimationIndex < animationObjects.Length)
        {
            // Activeer de volgende animatie
            animationObjects[currentAnimationIndex].SetActive(true);

            // Start een coroutine om de animatie te beëindigen na 'animationDuration' seconden
            StartCoroutine(AnimateAndDisable(animationDuration));

            currentAnimationIndex++;
        }
    }

    private IEnumerator AnimateAndDisable(float duration)
    {
        isAnimating = true;
        yield return new WaitForSeconds(duration);
        animationObjects[currentAnimationIndex - 1].SetActive(false);
        yield return new WaitForSeconds(delayBeforeNextAnimation); // Voeg een vertraging toe
        isAnimating = false;
        NextAnimation(); // Start de volgende animatie na de vertraging
    }
}
