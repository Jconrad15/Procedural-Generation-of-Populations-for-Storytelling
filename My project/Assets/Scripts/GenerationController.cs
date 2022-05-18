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

        // Generate initial settlements
        Settlement[] settlements = new Settlement[settlementCount];
        for (int i = 0; i < settlementCount; i++)
        {
            SettlementPrototype p = new SettlementPrototype();
            settlements[i] = new Settlement(Vector2.zero, p);
        }


    }

    void Update()
    {
        
    }
}
