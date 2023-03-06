using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDamReceiver : DamageReceiver
{
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkCtrl();
    }
    [SerializeField] protected JunkCtrl junkCtrl;
    protected virtual void LoadJunkCtrl()
    {
        if(junkCtrl != null) return;
        junkCtrl = FindObjectOfType<JunkCtrl>();
        Debug.Log(transform.name + ": LoadJunkCtrl", gameObject);

    }
    protected override void OnDead()
    {
        junkCtrl.JunkDespawn.DespawnObject();        
    }
    protected override void Reborn()
    {
        base.Reborn();
        hpMax = junkCtrl.JunkSO.hpMax;
        hp = hpMax;
        Debug.LogWarning("Reborn", gameObject);
    }


}
