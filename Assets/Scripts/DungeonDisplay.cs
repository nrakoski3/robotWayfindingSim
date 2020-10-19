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
    public Tilemap floor_tilemap;
    public Tilemap wall_tilemap;
    public Tilemap decorations_tilemap;
    public Tilemap collectibles_tilemap;
    public Tile base_tile;
    public Tile floor_tile;
    public Tile wall_tile;
    public Tile floor_tile2;
    public Tile wall_vertical;
    public Tile wall_left_corner;
    public Tile wall_right_corner;
    public Tile wall_left;
    public Tile wall_right;
    void Start()
    {
        input_array = new int[100, 100];
        init_input_array();
        for (int i = 0; i < input_array.GetLength(0); i++)
        {
            for (int j = 0; j < input_array.GetLength(1); j++)
            {
                Vector3Int b = new Vector3Int(i, j, 0);
                floor_tilemap.SetTile(b, base_tile);
                if (input_array[i, j] == 0)
                {
                    floor_tilemap.SetTile(b, floor_tile);
                }
                else if (input_array[i, j] == 1)
                {
                    floor_tilemap.SetTile(b, floor_tile2);
                }
                else if (input_array[i, j] == 2)
                {
                    floor_tilemap.SetTile(b, floor_tile);
                }
                else if (input_array[i, j] == 3)
                {
                    floor_tilemap.SetTile(b, floor_tile2);
                }

                if (i == 0)
                {
                    wall_tilemap.SetTile(b, wall_left);
                }

                if (i == input_array.GetLength(0) - 1)
                {
                    wall_tilemap.SetTile(b, wall_right);
                }

                if (j == 0)
                {
                    wall_tilemap.SetTile(b, wall_vertical);
                }

                if (j == input_array.GetLength(1) - 1)
                {
                    wall_tilemap.SetTile(b, wall_vertical);
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
                input_array[i, j] = (j) % 4;
            }
        }
    }
}
