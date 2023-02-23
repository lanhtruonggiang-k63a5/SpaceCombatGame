using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawn : DespawnByDistance
{
    protected override void ResetValue()
    {
        base.ResetValue();
        maxDis = 25f;
    }

    protected override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
    
}
