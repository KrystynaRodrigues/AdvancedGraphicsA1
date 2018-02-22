using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScanCountScript: MonoBehaviour
{
    public int scansRemaining = 6;
    public Text scansText;

    void Update()
    {
        this.GetComponent<ScanCountScript>().enabled = false;
        this.GetComponent<ScanCountScript>().enabled = true;
        Counter();
    }

    void Counter()
    {
        if(GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().scanModeOn)
        {
            if (scansRemaining >= 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    scansRemaining--;
                    scansText.text = "" + scansRemaining;
                }
            }

            else 
            {
                if(scansRemaining == 0)
                {
                    GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().scanModeOn = false;
                    this.GetComponent<ScanCountScript>().enabled = false;
                }
            }
        }

        else if (GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().scanModeOn == false)
        {

        }



    }
}
