using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class ItemPickupable : ItemAbstract
{
    [Header("Item Pickupable")]
    [SerializeField] protected CircleCollider2D _collider;
    public static ItemEnum String2ItemCode(string itemName)
    {
        return (ItemEnum)System.Enum.Parse(typeof(ItemEnum), itemName);
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
    }
    protected virtual void LoadCollider()
    {
        if (_collider != null) return;
        this._collider = transform.GetComponent<CircleCollider2D>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.2f;
        Debug.Log(transform.name + "load Collider ", gameObject);
    }
    public virtual ItemEnum GetItemEnum()
    {
        return ItemPickupable.String2ItemCode(transform.parent.name);
    }
    public virtual void Picked()
    {
        this.ItemCtrl.ItemDespawn.DespawnObject();
    }
    
    public virtual void OnMouseDown()
    {
        PlayerCtrl.Instance.PlayerPickup.ItemPickup(this);
    }

}
