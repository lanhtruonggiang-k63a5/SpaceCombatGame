using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCtrl : GiangMonoBehavior
{
    [Header("ShipCtrl")]
    public Inventory inventory;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadInventory();
    }
    protected virtual void LoadInventory(){
        if(inventory != null)return;
        inventory = GetComponentInChildren<Inventory>();
        Debug.Log(transform.name + "Load inventory", gameObject);
    }
}
