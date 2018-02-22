using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetPointsScript : MonoBehaviour
{
    public Text score;
    public int currentPoints;

     void Start()
     {
        score.GetComponent<Text>();
     }

    void Awake()
    {
        currentPoints = 0;
    }

    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (this.gameObject.tag == "scoreMax")
            {
                currentPoints = currentPoints + 5000;

                
            }

            if (this.gameObject.tag == "scoreHalf")
            {
                currentPoints = currentPoints +500;

            }

            if (this.gameObject.tag == "scoreQuarter")
            {
                currentPoints = currentPoints + 300;
            }

            if (this.gameObject.tag == "scoreMin")
            {
                currentPoints = currentPoints + 100;
            }
            score.text = "" + currentPoints;
        }

    }

        
	
}
