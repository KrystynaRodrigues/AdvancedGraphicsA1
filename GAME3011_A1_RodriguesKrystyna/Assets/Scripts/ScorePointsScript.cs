using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScorePointsScript : MonoBehaviour
{
    public bool scoreMax;
    public bool scoreHalf;
    public bool scoreQuarter;
    public bool scoreMin;

    public GameObject maxPointsWaddle;
    public GameObject halfPointsWaddle;
    public GameObject quarterPointsWaddle;
    public GameObject minPointsWaddle;

    void OnMouseDown()
    {
        if (GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().extractModeOn == true)
        {
            if (this.gameObject.tag == "MaxVal")
            {
                scoreMax = true;
                GameObject maxWaddle; 
                maxWaddle = Instantiate(maxPointsWaddle, transform.position, transform.rotation) as GameObject;
            }
            if (this.gameObject.tag == "HalfVal")
            {
                scoreHalf = true;
                GameObject halfWaddle;
                halfWaddle = Instantiate(halfPointsWaddle, transform.position, transform.rotation) as GameObject;
            }
            if (this.gameObject.tag == "QuarterVal")
            {
                scoreQuarter = true;
                GameObject quarterWaddle;
                quarterWaddle = Instantiate(quarterPointsWaddle, transform.position, transform.rotation) as GameObject;
            }
            if (this.gameObject.tag == "MinVal")
            {
                scoreMin = true;
                GameObject minWaddle;
                minWaddle = Instantiate(minPointsWaddle, transform.position, transform.rotation) as GameObject;
            }
        }

    }


}
