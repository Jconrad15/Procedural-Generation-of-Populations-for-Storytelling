using System;

/// <summary>
/// A product is a resource function.
/// </summary>

[Serializable]
public class Product
{
    public ResourceFunctionType Type;

    // R is the resource that is being produced
    public Resource resource;
    public float resourceMultiplier;

    public TerrainType terrainType;

    // Minimum and maximum distance to the terrain type
    public float minimumDistance;
    public float maximumDistance;
}
