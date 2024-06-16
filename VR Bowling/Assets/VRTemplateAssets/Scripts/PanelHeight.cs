using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelHeight : MonoBehaviour
{
    public Slider slider;
    public GameObject gameObj;
    
    public void changeHeight() {
        gameObj.transform.position = new Vector3(gameObj.transform.position.x, 2f * slider.value + 1.5f, gameObj.transform.position.z);
    }
}
