using System;
using System.Collections.Generic;

[Serializable]
public class Relation
{
    public RelationType type;
    public List<Settlement> settlements;
    public float preferredDistance;
    public float maximumDistance;
    
    // A set of resouces that can be exchanged for this relation
    public List<Resource> resources;

    // Optional relation's attitude
    public Attitude attitude;
}
