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

        Settlement[] settlements = CreateInitialSettlements();

        // Determine where the settlements should go
        settlements = EvolutionaryAlgorithm
            .DetermineSettlementLocations(landscape, settlements);




    }

    private Settlement[] CreateInitialSettlements()
    {
        Settlement[] settlements = new Settlement[settlementCount];
        for (int i = 0; i < settlementCount; i++)
        {
            SettlementPrototype prototype = GetRandomSettlementPrototype();

            // Generate initial settlements at random locations
            settlements[i] = new Settlement(RandomLocation(), prototype);

            int addDistrictCount = Random.Range(prototype.minDistricts, prototype.maxDistricts + 1);
            for (int j = 0; j < addDistrictCount; j++)
            {
                settlements[i].districts.Add(
                    GetRandomDistrictFromDistrictPrototype(prototype));
            }
        }

        return settlements;
    }

    private SettlementPrototype GetRandomSettlementPrototype()
    {
        return settlementPrototypes[Random.Range(0, settlementPrototypes.Length)];
    }

    private static District GetRandomDistrictFromDistrictPrototype(
        SettlementPrototype prototype)
    {
        return prototype.districts[Random.Range(0, prototype.districts.Count)].district;
    }

    private (int, int) RandomLocation()
    {
        return (Random.Range(0, width), Random.Range(0, height));
    }


}
