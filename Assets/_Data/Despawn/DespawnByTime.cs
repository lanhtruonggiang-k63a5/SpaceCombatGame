using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DespawnByTime : Despawn
{
    [SerializeField] protected float delayTime;
    protected float timer;

    protected override void OnEnable()
    {
        base.OnEnable();
        this.timer=0f;
    }


    protected override bool CanDespawn()
    {
        timer += Time.deltaTime;
        if(timer > delayTime) return true;
        return false;

    }
}
