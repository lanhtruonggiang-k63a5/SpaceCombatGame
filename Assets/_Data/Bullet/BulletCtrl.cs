using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : GiangMonoBehavior
{
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender { get => damageSender; }

    [SerializeField] protected BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn { get => bulletDespawn; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadDamageSender();
        LoadBulletDespawn();
    }
    protected virtual void LoadDamageSender()
    {
        if (damageSender != null) return;
        damageSender = transform.GetComponentInChildren<DamageSender>();
        Debug.Log(transform.name + ": LoadDamageSender", gameObject);

    }
    protected virtual void LoadBulletDespawn()
    {
        if (bulletDespawn != null) return;
        bulletDespawn = transform.GetComponentInChildren<BulletDespawn>();
        Debug.Log(transform.name + ": LoadBulletDespawn", gameObject);
    }

}
