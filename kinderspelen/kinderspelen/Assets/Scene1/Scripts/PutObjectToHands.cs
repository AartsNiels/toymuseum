using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutObjectToHands : MonoBehaviour
{
    public GameObject rightHandRay;
    public GameObject leftHandRay;

    public GameObject attachL;
    public GameObject attachR;

    private void Start()
    {
        Transform[] ObjectChildrensR;
        ObjectChildrensR = rightHandRay.GetComponentsInChildren<Transform>();
        attachR = System.Array.Find(ObjectChildrensR, p => p.gameObject.name == "[Ray Interactor] Attach").gameObject;

        Transform[] ObjectChildrensL;
        ObjectChildrensL = leftHandRay.GetComponentsInChildren<Transform>();
        attachL = System.Array.Find(ObjectChildrensL, p => p.gameObject.name == "[Ray Interactor] Attach").gameObject;
    }

    public void addObjectToHands()
    {

        if (attachL.transform.localPosition.z != 0)
        {
            attachL.transform.localPosition = new Vector3(attachL.transform.localPosition.x , attachL.transform.localPosition.y, 0);
        }
        if (attachR.transform.localPosition.z != 0)
        {
            attachR.transform.localPosition = new Vector3(attachR.transform.localPosition.x, attachR.transform.localPosition.y, 0);
        }
    }
}
