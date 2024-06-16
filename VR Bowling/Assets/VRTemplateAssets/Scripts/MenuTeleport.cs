using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuTeleport : MonoBehaviour
{
    public GameObject gameObj;
    public GameObject gameObj_1;
    public GameObject gameObj_2;
    public GameObject gameObj_3;
    public TMP_Dropdown dropdown;
    public Transform playerTransform;
    
    public void moveMenu()
    {
        int selectedIndex = dropdown.value;
        string selectedValue = dropdown.options[selectedIndex].text;

        if (selectedValue == "Left Lane") {
            gameObj.transform.position = new Vector3(1.8f, gameObj.transform.position.y, 2.6f);
            gameObj_1.transform.position = new Vector3(1.8f, gameObj_1.transform.position.y, -3.43f);
            gameObj_2.transform.position = new Vector3(1.8f, gameObj_2.transform.position.y, gameObj_2.transform.position.z);
            gameObj_3.transform.position = new Vector3(1.8f, gameObj_3.transform.position.y, gameObj_3.transform.position.z);
            playerTransform.position = new Vector3(1.8f, 0.0f, 4.4f);
        }
        else if (selectedValue == "Right Lane") {
            gameObj.transform.position = new Vector3(-1.6f, gameObj.transform.position.y, 2.6f);
            gameObj_1.transform.position = new Vector3(-1.6f, gameObj_1.transform.position.y, -3.43f);
            gameObj_2.transform.position = new Vector3(-1.6f, gameObj_2.transform.position.y, gameObj_2.transform.position.z);
            gameObj_3.transform.position = new Vector3(-1.6f, gameObj_3.transform.position.y, gameObj_3.transform.position.z);
            playerTransform.position = new Vector3(-1.6f, 0.0f, 4.4f);
        }
        else if (selectedValue == "Middle Lane") {
            gameObj.transform.position = new Vector3(0.058f, gameObj.transform.position.y, 2.6f);
            gameObj_1.transform.position = new Vector3(0.1f, gameObj_1.transform.position.y, -3.43f);
            gameObj_2.transform.position = new Vector3(0.1f, gameObj_2.transform.position.y, gameObj_2.transform.position.z);
            gameObj_3.transform.position = new Vector3(0.1f, gameObj_3.transform.position.y, gameObj_3.transform.position.z);
            playerTransform.position = new Vector3(0.043f, 0.0f, 4.4f);
        }
    }
}
