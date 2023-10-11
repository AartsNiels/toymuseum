using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateObjectOnTouch : MonoBehaviour
{
    private XRGrabInteractable interactable;

    [SerializeField]
    private GameObject objectToActivate;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();

        if (interactable == null)
        {
            Debug.LogError("XRGrabInteractable component not found on the object.");
        }
    }

    private void OnEnable()
    {
        interactable.onSelectEntered.AddListener(ActivateObject);
    }

    private void OnDisable()
    {
        interactable.onSelectEntered.RemoveListener(ActivateObject);
    }

    private void ActivateObject(XRBaseInteractor interactor)
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
    }
}
