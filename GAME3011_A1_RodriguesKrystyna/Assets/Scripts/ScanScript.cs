using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanScript : MonoBehaviour
{
    Color mouseOverColor = Color.green;

    Color originalBlockColor;

    SpriteRenderer blockRenderer;


    void Start()
    {
        blockRenderer = GetComponent<SpriteRenderer>();

        originalBlockColor = blockRenderer.color;

    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().scanModeOn)
        {
            if (collider.tag == "Block" && Input.GetMouseButton(0))
            {
                Destroy(gameObject);
            }
        }
        else if (GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().scanModeOn == false)
        {
            GameObject.FindGameObjectWithTag("Toggle").GetComponent<SwitchModeScript>().extractModeOn = true;
        }

    }

    void OnMouseOver()
    {
        blockRenderer.color = originalBlockColor;
        this.gameObject.tag = "Block";
    }

    void OnMouseExit()
    {
        blockRenderer.color = originalBlockColor;
        this.gameObject.tag = "BlockSelect";
    }

    void OnMouseUp()
    {
        Destroy(gameObject);
    }
	
}
