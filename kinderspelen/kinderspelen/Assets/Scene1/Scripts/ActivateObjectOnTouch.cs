using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class ActivateObjectOnTouch : MonoBehaviour
{
    public GameObject objectToActivate;
    private XRBaseInteractable interactable;
    private bool isActivated = false;

    private Coroutine activationCoroutine;
    private Coroutine deactivationCoroutine;

    private void Start()
    {
        interactable = GetComponent<XRBaseInteractable>();
        interactable.onSelectEntered.AddListener(ActivateObject);
        interactable.onSelectExited.AddListener(DeactivateObject);
    }

    public void ActivateObject(XRBaseInteractor interactor)
    {
        if (activationCoroutine != null)
        {
            StopCoroutine(activationCoroutine);
        }

        activationCoroutine = StartCoroutine(ActivateObjectWithDelay(2f));
    }

    public void DeactivateObject(XRBaseInteractor interactor)
    {
        if (deactivationCoroutine != null)
        {
            StopCoroutine(deactivationCoroutine);
        }

        deactivationCoroutine = StartCoroutine(DeactivateObjectWithDelay(10f));
    }

    private IEnumerator ActivateObjectWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        objectToActivate.SetActive(true);
        isActivated = true;
    }

    private IEnumerator DeactivateObjectWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        objectToActivate.SetActive(false);
        isActivated = false;
    }
}
