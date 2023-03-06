using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : GiangMonoBehavior
{
    [SerializeField] protected int damage = 1;

    
    public virtual void Send(Transform obj){
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        Debug.Log(damageReceiver);
        Send(damageReceiver);
    }
    public virtual void Send(DamageReceiver damageReceiver){
        damageReceiver.Deduct(damage);
        DestroyObject();
    }
    protected virtual void DestroyObject(){

        // Destroy(transform.parent.gameObject);
    }


}
