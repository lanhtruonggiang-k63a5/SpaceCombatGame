using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : PlayerAbstract
{
    public virtual void ItemPickup(ItemPickupable itemPickupable)
    {
        ItemEnum itemEnum = itemPickupable.GetItemEnum();
        if(playerCtrl.CurrentShip.inventory.AddItem(itemEnum,1)){
            itemPickupable.Picked();
        }
    }
}
