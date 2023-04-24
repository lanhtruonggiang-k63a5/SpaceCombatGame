using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAbstract : GiangMonoBehavior
{
    [Header("PlayerCtrl")]
    [SerializeField] protected PlayerCtrl playerCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (playerCtrl != null) return;
        this.playerCtrl = GetComponentInParent<PlayerCtrl>();
        Debug.Log(transform.name + " Load PlayerCtrl ",gameObject);
    }
}
