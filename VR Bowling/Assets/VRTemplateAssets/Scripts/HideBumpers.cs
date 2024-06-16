using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HideBumpers : MonoBehaviour
{
    public Toggle toggle;

    public List<GameObject> gutters;
    public Vector3 moveDownOffset = new Vector3(0, -0.15f, 0);
    private Dictionary<GameObject, Vector3> initialGutterPositions;
    private bool isGuttersDown = false;
    public float animationDuration = 1.0f;

    public void toggleBumpers() {
        if (toggle.isOn) {
            isGuttersDown = false;
        }
        else {
            isGuttersDown = true;
        }
        ToggleGutters();
    }

    void Awake()
    {
        // Initialize the dictionary to store initial gutter positions
        initialGutterPositions = new Dictionary<GameObject, Vector3>();
        foreach (GameObject gutter in gutters)
        {
            if (gutter != null)
            {
                initialGutterPositions[gutter] = gutter.transform.position;
            }
        }
    }

    private void ToggleGutters()
    {

        StopAllCoroutines();
        foreach (GameObject gutter in gutters)
        {
            if (gutter != null)
            {
                Vector3 targetPosition = isGuttersDown ? initialGutterPositions[gutter] + moveDownOffset : initialGutterPositions[gutter];
                StartCoroutine(AnimateGutterMovement(gutter, targetPosition));
            }
        }

        // Print the displacement vector
        Debug.Log("Displacement vector: " + (isGuttersDown ? moveDownOffset : Vector3.zero));
        // Display the state of the gutters
        Debug.Log("Gutters are " + (isGuttersDown ? "down" : "up"));
    }

    private IEnumerator AnimateGutterMovement(GameObject gutter, Vector3 targetPosition)
    {
        Vector3 startPosition = gutter.transform.position;
        float elapsedTime = 0;

        while (elapsedTime < animationDuration)
        {
            gutter.transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / animationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        gutter.transform.position = targetPosition;
    }
}