using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : GiangMonoBehavior
{
    [SerializeField] protected int damage = 1;

    
    public virtual void Send(Transform obj){
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        if(damageReceiver == null) return;
        Debug.Log(damageReceiver);
        Send(damageReceiver);
        this.OnHit();
    }
    public virtual void Send(DamageReceiver damageReceiver){
        damageReceiver.Deduct(damage);
        DestroyObject();
    }
    protected virtual void DestroyObject(){

        // Destroy(transform.parent.gameObject);
    }
    protected virtual void OnHit()
    {
        string hitName = FXSpawner.hitOne;
        Vector3 pos = transform.position;
        Quaternion ros = transform.rotation;
        Transform hitFX = FXSpawner.Instance.Spawn(hitName, pos, ros);
        hitFX.gameObject.SetActive(true);
    }


}
