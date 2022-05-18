using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class District
{
    public string name;
    public List<Need> needs;
    public List<Product> products;

    // List of relations this district allows its parent settlement to use
    public List<Relation> relations;
}
