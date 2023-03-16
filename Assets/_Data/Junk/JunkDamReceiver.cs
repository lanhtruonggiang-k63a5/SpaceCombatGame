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
        this.OnDeadFX();
        junkCtrl.JunkDespawn.DespawnObject();        
    }
    protected virtual void OnDeadFX(){
        string fxname = FXSpawner.smokeOne;
        Transform fxSmoke = FXSpawner.Instance.Spawn(fxname,transform.position,transform.rotation);
        fxSmoke.gameObject.SetActive(true);
    }
    protected override void Reborn()
    {
        base.Reborn();
        hpMax = junkCtrl.JunkSO.hpMax;
        hp = hpMax;
        Debug.LogWarning("Reborn", gameObject);
    }


}
