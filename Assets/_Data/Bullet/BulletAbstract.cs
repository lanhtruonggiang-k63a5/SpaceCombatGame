using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAbstract : GiangMonoBehavior
{
    [SerializeField] protected BulletCtrl bulletCtrl;

    public BulletCtrl BulletCtrl {get => bulletCtrl;}

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadDamageReceiver();
    }
    protected virtual void LoadDamageReceiver(){
        if(bulletCtrl != null) return;
        bulletCtrl = transform.parent.GetComponent<BulletCtrl>();
        Debug.Log(transform.name + ": LoadDamageReceiver", gameObject);
    }

}
