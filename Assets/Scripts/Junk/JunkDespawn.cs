using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawn : DespawnByTime
{
    protected override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
    
}
