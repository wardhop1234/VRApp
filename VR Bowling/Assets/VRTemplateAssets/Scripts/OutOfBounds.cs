using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0f)
        {
            Debug.Log(transform.position);
            rb.velocity = Vector3.zero;
            
            transform.position = initialPosition;
            transform.rotation = initialRotation;
            transform.localScale = initialScale;

            rb.velocity = Vector3.zero;
        }
    }
}
