using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RelationType { a,b, c };

public class Relation
{
    public RelationType type;
    public List<Settlement> settlements;
    public float preferredDistance;
    public float maximumDistance;
    
    // A set of resouces that can be exchanged for this relation
    public List<Resource> resources;

    // Optional relation's attitude
    public float attitude;
}
