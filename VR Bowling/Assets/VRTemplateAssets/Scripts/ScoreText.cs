using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TextMeshProUGUI textMeshPro;
    public List<GameObject> leftPins = new List<GameObject>();
    public List<GameObject> midPins = new List<GameObject>();
    public List<GameObject> rightPins = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int selectedIndex = dropdown.value;
        int count = 10;
        string selectedValue = dropdown.options[selectedIndex].text;
        if (selectedValue == "Left Lane") {
            foreach (GameObject obj in leftPins) {
                float x = obj.transform.eulerAngles.x;
                // float y = obj.transform.eulerAngles.y;
                if (x > 280 || x < 260) {
                    count -=1;
                }
            }
            textMeshPro.text = (count).ToString() + "\nPins";
        }
        else if (selectedValue == "Right Lane") {
            foreach (GameObject obj in rightPins) {
                float x = obj.transform.eulerAngles.x;
                // float y = obj.transform.eulerAngles.y;
                if (x > 280 || x < 260) {
                    count -=1;
                }
            }
            textMeshPro.text = (count).ToString() + "\nPins";
        }
        else if (selectedValue == "Middle Lane") {
            foreach (GameObject obj in midPins) {
                float x = obj.transform.eulerAngles.x;
                // float y = obj.transform.eulerAngles.y;
                // float z = obj.transform.eulerAngles.z;
                // Debug.Log("x:" + x + " y:" + y + " z:" + z);
                if (x > 280 || x < 260) {
                    count -=1;
                }
            }
            textMeshPro.text = (count).ToString() + "\nPins";
        }
    }
}
