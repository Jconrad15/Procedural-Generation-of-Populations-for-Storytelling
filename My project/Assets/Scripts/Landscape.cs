using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landscape
{
    public int width;
    public int height;

    public float[] heightMap;
    public TerrainType[] terrainTypeMap;

    public Landscape(int width, int height,
        float[] heightMap, TerrainType[] terrainTypeMap)
    {
        this.width = width;
        this.height = height;
        this.heightMap = heightMap;
        this.terrainTypeMap = terrainTypeMap;
    }

    public TerrainType GetTerrainTypeAtPos((int,int) position)
    {
        int index = PositionToIndex(position);
        return terrainTypeMap[index];
    }

    private int PositionToIndex((int,int) position)
    {
        return position.Item1 + (width * position.Item2);
    }

    //public float GetDistanceToTerrainType()

}
