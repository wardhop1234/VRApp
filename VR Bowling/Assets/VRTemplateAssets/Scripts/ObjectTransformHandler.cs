using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransformHandler : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private Vector3 initialScale;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        initialScale = transform.localScale;

        rb = GetComponent<Rigidbody>();
    }

    public void ResetToInitialTransform()
    {
        rb.velocity = Vector3.zero;
        
        // Reset the object's transform to its initial values
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        transform.localScale = initialScale;

        rb.velocity = Vector3.zero;
    }
}
