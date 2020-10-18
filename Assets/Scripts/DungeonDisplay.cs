using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;


public class DungeonDisplay : MonoBehaviour
{
    int[,] input_array;
    public Tilemap tilemap;
    public Tile base_tile;
    public Tile floor_tile;
    public Tile wall_tile;
    public Tile floor2_tile;
    void Start()
    {
        input_array = new int[100, 100];
        init_input_array();
        for (int i = 0; i < input_array.GetLength(0); i++)
        {
            for (int j = 0; j < input_array.GetLength(1); j++)
            {
                Debug.Log(input_array[i, j].ToString());
                Vector3Int b = new Vector3Int(i, j, 0);
                if (input_array[i, j] == 0)
                {
                    tilemap.SetTile(b, base_tile);
                } else if (input_array[i, j] == 1)
                {
                    tilemap.SetTile(b, floor_tile);
                }
                else if (input_array[i, j] == 2)
                {
                    tilemap.SetTile(b, floor2_tile);
                }
                else if (input_array[i, j] == 3)
                {
                    tilemap.SetTile(b, wall_tile);
                }
            }
        }
        
    }

    void init_input_array()
    {
        for (int i = 0; i < 100; i++)
        {
            for (int j  = 0; j < 100; j++)
            {
                input_array[i, j] = (i + j) % 4;
            }
        }
    }
}
