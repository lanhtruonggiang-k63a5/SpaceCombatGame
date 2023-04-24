using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCtrl : GiangMonoBehavior
{
    public ItemDespawn ItemDespawn { get => itemDespawn; }
    [SerializeField] protected ItemDespawn itemDespawn;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadItemDespawn();
    }
    protected virtual void LoadItemDespawn()
    {
        if (itemDespawn != null) return;
        itemDespawn = transform.GetComponentInChildren<ItemDespawn>();
        Debug.Log(transform.name + ": LoadItemDespawn ", gameObject);
    }

}
