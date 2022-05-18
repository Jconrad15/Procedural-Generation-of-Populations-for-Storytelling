using System;
using System.Collections.Generic;
using UnityEngine;

public class Settlement
{
    public (int, int) position;
    public List<District> districts;
    public List<Settlement> relatedSettlements;
    public SettlementPrototype prototype;

    public Settlement((int, int) position, SettlementPrototype prototype)
    {
        this.position = position;
        districts = new List<District>();
        relatedSettlements = new List<Settlement>();
        this.prototype = prototype;
    }

    public Settlement((int, int) position, List<District> districts,
        List<Settlement> relatedSettlements, SettlementPrototype prototype)
    {
        this.position = position;
        this.districts = districts;
        this.relatedSettlements = relatedSettlements;
        this.prototype = prototype;
    }
}
