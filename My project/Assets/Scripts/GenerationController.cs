using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationController : MonoBehaviour
{
    [SerializeField]
    private int width;
    [SerializeField]
    private int height;
    [SerializeField]
    private int settlementCount;

    [SerializeField]
    private SettlementPrototype[] settlementPrototypes;

    void Start()
    {
        // First generate the map

        HeightMapGenerator hmg =
            new HeightMapGenerator(width, height);

        TerrainTypeMapGenerator ttmg =
            new TerrainTypeMapGenerator(width, height, hmg.HeightMap);

        // Now define the input landscape
        Landscape landscape = new Landscape(
            width, height, hmg.HeightMap, ttmg.TerrainTypeMap);

        // Generate initial settlements at random locations
        Settlement[] settlements = new Settlement[settlementCount];
        for (int i = 0; i < settlementCount; i++)
        {
            settlements[i] =
                new Settlement(RandomLocation(), settlementPrototypes[0]);
        }

        // Determine where the settlements should go
        settlements = EvolutionaryAlgorithm
            .DetermineSettlementLocations(landscape, settlements);




    }

    private Vector2 RandomLocation()
    {
        return new Vector2(Random.Range(0, width), Random.Range(0, height));
    }


}
