using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTutorial : MonoBehaviour
{
    public GameObject gameObj;

    public void close() {
        gameObj.SetActive(false);
    }
}
