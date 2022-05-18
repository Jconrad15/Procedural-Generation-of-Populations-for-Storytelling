using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EvolutionaryAlgorithm
{

    public static Settlement[] DetermineSettlementLocations(
        Landscape landscape, Settlement[] settlements)
    {
        int maxIterations = 10;
        int currentIteration = 0;


        // int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        float[,] scores = new float[settlements.Length, maxIterations];
        Vector2[,] locations = new Vector2[settlements.Length, maxIterations];

        // For all iterationss
        for (int i = 0; i < maxIterations; i++)
        {

            // Determine suitablity score for
            // the settlement locations in the iteration
            for (int j = 0; j < settlements.Length; j++)
            {
                scores[j, currentIteration] =
                    DetermineScore(landscape, settlements[i]);

                locations[j, currentIteration] =
                    settlements[j].position;
            }

            currentIteration++;
        }

        return settlements;
    }

    private static float DetermineScore(Landscape l, Settlement s)
    {
        
        return 0;
    }

}
