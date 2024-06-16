using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CloseThrowAssist : MonoBehaviour
{
    public GameObject gameObj;
    public Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        gameObj.SetActive(false);
    }

    public void open() {
        if (toggle.isOn) {
            gameObj.SetActive(true);
        }
        else {
            gameObj.SetActive(false);
        }
    }

    public void close() {
        gameObj.SetActive(false);
    }
}
