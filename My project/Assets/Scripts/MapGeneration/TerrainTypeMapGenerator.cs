using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTypeMapGenerator
{
    private int width;
    private int height;
    public TerrainType[] TerrainTypeMap { get; private set; }

    public TerrainTypeMapGenerator(int width, int height, float[] heightMap)
    {
        this.width = width;
        this.height = height;
        TerrainTypeMap = GenerateTerrainTypeMap(heightMap);
    }

    public TerrainType[] GenerateTerrainTypeMap(float[] heightMap)
    {
        TerrainType[] map = new TerrainType[width * height];

        // Basic classification of heightmap
        // Can be changed
        for (int i = 0; i < heightMap.Length; i++)
        {
            if (heightMap[i] < 0.2f)
            {
                map[i] = TerrainType.Water;
            }
            else if (heightMap[i] < 0.8f)
            {
                map[i] = TerrainType.Grassland;
            }
            else
            {
                map[i] = TerrainType.Mountain;
            }
        }

        return map;
    }

}
