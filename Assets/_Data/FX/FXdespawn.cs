using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXdespawn : DespawnByTime
{
    public override void DespawnObject()
    {
        FXSpawner.Instance.Despawn(transform.parent);
    }

}
