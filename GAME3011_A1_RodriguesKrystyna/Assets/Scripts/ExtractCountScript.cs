using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ExtractCountScript : MonoBehaviour {

    public int extractsRemaining = 3;
    public Text extractText;

    void Update()
    {
        this.GetComponent<ExtractCountScript>().enabled = false;
        this.GetComponent<ExtractCountScript>().enabled = true;
        Counter();
    }

    void Counter()
    {
        if (GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().extractModeOn)
        {
            if (extractsRemaining >= 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    extractsRemaining--;
                    extractText.text = "" + extractsRemaining;
                }
            }

            else
            {
                if (extractsRemaining == 0)
                {
                    GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().extractModeOn = false;
                    this.GetComponent<ExtractCountScript>().enabled = false;
                }
            }
        }

        else if (GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().extractModeOn == false)
        {
           
        }



    }
}
