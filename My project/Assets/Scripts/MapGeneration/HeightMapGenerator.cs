using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightMapGenerator
{
    private int width;
    private int height;
    public float[] HeightMap { get; private set; }

    public HeightMapGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
        HeightMap = GenerateHeightMap();
    }

    public float[] GenerateHeightMap()
    {
        float[] map = new float[width * height];

        // For now, this is just a slope
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                map[x + (width * y)] = x / width;
            }
        }

        return map;
    }
}
