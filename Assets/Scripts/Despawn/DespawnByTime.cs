using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DespawnByTime : Despawn
{
    [SerializeField] private float maxTime;
    private float counter;

    protected override bool CanDespawn()
    {
        if (counter < maxTime)
        {
            counter += Time.deltaTime;
            return false;
        }
        else
        {
            counter = 0f;
            return true;
        }

    }
}
