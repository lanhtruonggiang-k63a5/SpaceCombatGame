using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventoryDrop : InventoryAbstract
{
    protected override void Start()
    {
        Invoke(nameof(Test), 2);
    }
    protected virtual void Test()
    {
        this.DropItem();
    }
    protected virtual void DropItem()
    {
        
    }
}
