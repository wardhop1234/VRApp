using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HideVideo : MonoBehaviour
{
    public Toggle toggle;
    public VideoPlayer videoPlayer;
    public GameObject gameObj;

    public void changeVideo() {
        if (toggle.isOn) {
            gameObj.SetActive(true);
        }
        else {
            gameObj.SetActive(false);
        }
    }
}
