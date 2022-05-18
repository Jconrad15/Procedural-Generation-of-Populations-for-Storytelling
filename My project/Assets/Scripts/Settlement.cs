using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settlement
{
    public Vector2 position;
    public List<District> districts;
    public List<Settlement> relatedSettlements;
    public SettlementPrototype prototype;

    public Settlement(Vector2 position, SettlementPrototype prototype)
    {
        this.position = position;
        districts = new List<District>();
        relatedSettlements = new List<Settlement>();
        this.prototype = prototype;
    }

    public Settlement(Vector2 position, List<District> districts,
        List<Settlement> relatedSettlements, SettlementPrototype prototype)
    {
        this.position = position;
        this.districts = districts;
        this.relatedSettlements = relatedSettlements;
        this.prototype = prototype;
    }
}
