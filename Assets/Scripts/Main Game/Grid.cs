using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public Column[] grid;
    public GameObject[,] tiles = new GameObject[100, 100];

    public GameObject dirt;
    public GameObject coal;
    public GameObject bedrock;

    public GameObject player;


    public class Column
    {
        public int height;
        public int[] tiles;
        public Column(int h, int row)
        {
            this.height = h;
            Generate(row);
        }
        public void Generate(int row)
        {
            tiles = new int[100];
            if (row == 0 || row == 99)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 0)
                    {
                        tiles[i] = 3;
                    }
                    else if (i > height) {
                        tiles[i] = 0;
                    }
                    else
                    {
                        tiles[i] = 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {

                    if (i == 0)
                    {
                        tiles[i] = 3;
                    }
                    else if (i == height)
                    {
                        tiles[i] = 1;
                    }
                    else if (i > height)
                    {
                        tiles[i] = 0;
                    }
                    else
                    {
                        int r = UnityEngine.Random.Range(0, 20);

                        if (r == 0) tiles[i] = 2;
                        else tiles[i] = 1;
                    }
                }
            }
        }

        // Use this for initialization
    }
    void Start()
    {
        Generate();
        InitBoard();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Generate()
    {
        grid = new Column[100];
        int currHeight = UnityEngine.Random.Range(60, 66);
        for (int i = 0; i < 100; i++)
        {
            grid[i] = new Column(currHeight, i);
            currHeight += UnityEngine.Random.Range(-1, 2);
        }
    }

    public void InitBoard()
    {
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                GameObject go = null;
                switch (grid[i].tiles[j])
                {

                    case 0:
                        break;
                    case 1:
                        go = Instantiate(dirt, new Vector3(i, j, 0), Quaternion.identity);

                        break;
                    case 2:
                        go = Instantiate(coal, new Vector3(i, j, 0), Quaternion.identity);
                        break;
                    case 3:

                        go = Instantiate(bedrock, new Vector3(i, j, 0), Quaternion.identity);

                        break;
                }

                try
                {
                    tiles[i, j] = go;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }


        player.transform.position = new Vector3(50, grid[50].height + 1, 0);
    }

}
