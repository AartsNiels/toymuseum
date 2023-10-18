using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateObjectOnTouch : MonoBehaviour
{
    public GameObject objectToActivate;
    private XRBaseInteractable interactable;
    private bool isActivated = false;

    private void Start()
    {
        interactable = GetComponent<XRBaseInteractable>();
        interactable.onSelectEntered.AddListener(ActivateObject);
        interactable.onSelectExited.AddListener(DeactivateObject);
    }

    public void ActivateObject(XRBaseInteractor interactor)
    {
        objectToActivate.SetActive(true);
        isActivated = true;
    }

    public void DeactivateObject(XRBaseInteractor interactor)
    {
        objectToActivate.SetActive(false);
        isActivated = false;
    }
}
