using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGridScript : MonoBehaviour
{
    public GameObject blockPrefab;

    public int gridX = 16; //16 blocks wide
    public int gridY = 16; // 16 blocks high

    public float spacingX = 0.0f; // spacing between blocks
    public float spacingY = 0.0f;

    public GameObject[] blockArray;

    public GameObject basicBlock;

    private int blockIndex = 0;

	// Use this for initialization
	void Start ()
    {
        CreateBackGrid ();
	}

	void CreateBackGrid ()
    {
        float blockOffsetX = 0.0f;
        float blockOffsetY = 0.0f;

        for(int createXBlocks = 0; createXBlocks < gridX; createXBlocks += 1)
        {
            for(int createYBlocks = 0; createYBlocks < gridY; createYBlocks += 1)
            {
                Vector3 blockPos = new Vector2(transform.position.x + blockOffsetX, transform.position.y + blockOffsetY);

                GameObject block = Instantiate(blockPrefab, blockPos, Quaternion.identity) as GameObject;

                blockArray = GameObject.FindGameObjectsWithTag("MinVal");

                blockOffsetY += transform.localScale.y + spacingY;
            }
            blockOffsetX += transform.localScale.x + spacingX;
            blockOffsetY = 0.0f;
        }

        for (int i = 0; i < 6; i++)
        {
            blockIndex = Random.Range(0, blockArray.Length);
            basicBlock = blockArray[blockIndex];
            basicBlock.GetComponent<SpriteRenderer>().color = Color.blue;
            basicBlock.gameObject.tag = "MaxVal";
        }
	}
}
