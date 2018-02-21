using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockScript : MonoBehaviour
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

        if (collider.tag == "Block" && Input.GetMouseButton(0))
        {
            Destroy(gameObject);
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
