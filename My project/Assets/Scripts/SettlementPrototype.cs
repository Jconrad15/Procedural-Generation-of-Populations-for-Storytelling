using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "settlement",
    menuName = "ScriptableObjects/SettlementPrototype", order = 2)]
public class SettlementPrototype: ScriptableObject
{
    public List<DistrictPrototypes> districts;
    public int minDistricts;
    public int maxDistricts;
}
