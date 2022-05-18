using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class District
{
    public List<Need> needs;
    public List<Product> products;

    // List of relations this district allows its parent settlement to use
    public List<Relation> relations;

}
