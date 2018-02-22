using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SwitchModeScript : MonoBehaviour
{

    public Toggle tog;
    public Text toggleText;
    public bool extractModeOn = false;
    public bool scanModeOn;
    // Use this for initialization
    void Start()
    {
        scanModeOn = true;
        Toggle tog = GetComponent<Toggle>();
        tog.onValueChanged.AddListener(delegate
        {
            ToggleModeSwitch(tog);
        });
        toggleText.text = "Scan Mode is: " + tog.isOn;
    }

    // Update is called once per frame
    void ToggleModeSwitch(Toggle change)
    {
        if (scanModeOn == true)
        {
            scanModeOn = false;
            extractModeOn = true;
        }
        else if (extractModeOn == true)
        {
            scanModeOn = true;
            extractModeOn = false;
        }

        toggleText.text = "Scan Mode is: " + tog.isOn;
    }
}
