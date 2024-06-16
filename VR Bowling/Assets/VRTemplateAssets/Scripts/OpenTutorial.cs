using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTutorial : MonoBehaviour
{
    public GameObject gameObj;

    public void open() {
        gameObj.SetActive(true);
    }
}
