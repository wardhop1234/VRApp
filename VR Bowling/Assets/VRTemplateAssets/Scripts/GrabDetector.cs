using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabDetection : MonoBehaviour
{
    public Toggle toggle;
    public ActionBasedController controller;
    private XRBaseInteractor interactor; // Reference to the XRBaseInteractor component
    private float prev = 100f;

    private void Start()
    {
        interactor = GetComponent<XRBaseInteractor>(); // Get the XRBaseInteractor component
    }

    private void Update()
    {
        if ((interactor.interactablesSelected.Count > 0) && (toggle.isOn))
        {
            IXRSelectInteractable selectedInteractable = interactor.interactablesSelected[0];
            XRBaseInteractable grabbedObject = selectedInteractable as XRBaseInteractable;
            
            if ((grabbedObject != null) && (grabbedObject.name == "Bowling Ball"))
            {
                // Debug.Log("Interactor grabbed object: " + grabbedObject.name);
                // Debug.Log(transform.position);
                // Add your custom logic here for when the interactor grabs an object
                float curr = transform.position.y;
                if (curr > prev) {
                    Debug.Log("here");
                    controller.SendHapticImpulse(0.5f, 0.1f);
                }
            }
        }
        prev = transform.position.y;
    }
}
