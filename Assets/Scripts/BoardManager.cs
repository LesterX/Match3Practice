using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int width;
    public int height;
    private Tile[,] tiles;
    public GameObject tilePrefab;
    public List<GameObject> characters = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        tiles = new Tile[width, height];
        SetUp();
    }

    // Create the board using a 2D array storing all the tiles stating at (0,0)
    private void SetUp()
    {
        // Prevent repeating characters
        int[] previousLeft = new int[height];
        int previousBelow = -1;

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 tempPos = new Vector2(i, j);
                GameObject emptyTile = Instantiate(tilePrefab, tempPos, Quaternion.identity) as GameObject;
                emptyTile.transform.parent = this.transform;
                emptyTile.name = "(" + i + "," + j + ")";

                List<int> possibleIndexes = new List<int>();
                for (int k = 0; k < characters.Count; k++) possibleIndexes.Add(k);
                possibleIndexes.Remove(previousLeft[j]);
                if (j != 0) possibleIndexes.Remove(previousBelow);

                Debug.Log(previousBelow);
                //Debug.Log("------------");
                //for (int p = 0; p < possibleIndexes.Count; p++) Debug.Log(possibleIndexes[p]);


                //Randomly pick a character from the character list
                int index = possibleIndexes[Random.Range(0, possibleIndexes.Count)];

                GameObject character = Instantiate(characters[index], tempPos, Quaternion.identity);
                previousLeft[j] = index;
                previousBelow = index;

                character.transform.parent = emptyTile.transform;
                character.name = emptyTile.name;
            }
        }
    }
}
