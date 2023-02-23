using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DespawnByDistance : Despawn
{
    [SerializeField] public float maxDis;
    
    protected override bool CanDespawn()
    {
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        if(distance<maxDis) return false;
        return true;

    }
}
