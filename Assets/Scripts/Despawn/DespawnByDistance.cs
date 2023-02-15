using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] private float maxDis;
    
    protected override bool CanDespawn()
    {
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        if(distance<maxDis) return false;
        return true;

    }
}
