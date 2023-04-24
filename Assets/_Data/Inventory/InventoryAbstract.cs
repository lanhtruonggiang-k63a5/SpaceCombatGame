using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAbstract : GiangMonoBehavior
{
    [Header("Inventory abstract")]
    [SerializeField] protected Inventory inventory;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInventory();
    }
    protected virtual void LoadInventory()
    {
        if (inventory != null) return;
        inventory = transform.parent.GetComponent<Inventory>();
        Debug.Log(transform.name + " Load Inventory ", gameObject);
    }
}
