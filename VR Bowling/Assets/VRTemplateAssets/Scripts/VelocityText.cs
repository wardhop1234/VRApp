using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class speed : MonoBehaviour
{
    public XRGrabInteractable grabLeft;
    public XRGrabInteractable grabMid;
    public XRGrabInteractable grabRight;
    public GameObject left;
    public GameObject mid;
    public GameObject right;
    public TextMeshProUGUI textMeshPro;  // Reference to the TextMeshPro component

    private void Start()
    {
        // Subscribe to the interaction events
        grabLeft.selectExited.AddListener(OnReleaseLeft);
        grabMid.selectExited.AddListener(OnReleaseMid);
        grabRight.selectExited.AddListener(OnReleaseRight);
    }
    private void OnReleaseLeft(SelectExitEventArgs args)
    {
        float speed_left = left.GetComponent<Rigidbody>().velocity.magnitude;
        if (speed_left >= 1.0f) {
            textMeshPro.text = (speed_left * 2.2).ToString("F2") + "\nmph";
        }
    }
    private void OnReleaseMid(SelectExitEventArgs args)
    {
        float speed_mid = mid.GetComponent<Rigidbody>().velocity.magnitude;
        if (speed_mid >= 1.0f) {
            textMeshPro.text = (speed_mid * 2.2).ToString("F2") + "\nmph";
        }
    }
    private void OnReleaseRight(SelectExitEventArgs args)
    {
        float speed_right = right.GetComponent<Rigidbody>().velocity.magnitude;
        if (speed_right >= 1.0f) {
            textMeshPro.text = (speed_right * 2.2).ToString("F2") + "\nmph";
        }
    }
}