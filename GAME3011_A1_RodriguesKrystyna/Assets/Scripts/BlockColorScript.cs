using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColorScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "MaxVal" && collider.tag != "QuarterVal")
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
            this.gameObject.tag = "HalfVal";
        }

        if(collider.tag == "HalfVal" && this.tag != "MaxVal" && this.tag != "HalfVal")
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
            this.gameObject.tag = "QuarterVal";
        }
    } 
	
}
