using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class ItemLooter : InventoryAbstract
{
    [SerializeField] protected CircleCollider2D _collider;
    [SerializeField] protected Rigidbody2D _rigidbody;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
        this.LoadRigidbody();
    }
    protected virtual void LoadCollider()
    {
        if (_collider != null) return;
        this._collider = transform.GetComponent<CircleCollider2D>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.6f;
        Debug.Log(transform.name + "load Collider ", gameObject);

    }
    protected virtual void LoadRigidbody()
    {
        if (_rigidbody != null) return;
        this._rigidbody = transform.GetComponent<Rigidbody2D>();
        this._rigidbody.bodyType = RigidbodyType2D.Kinematic;
        Debug.Log(transform.name + "load Collider ", gameObject);

    }
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        ItemPickupable itemPickupable = other.GetComponent<ItemPickupable>();
        if (itemPickupable == null) return;

        ItemEnum itemEnum =  itemPickupable.GetItemEnum();
        if(this.inventory.AddItem(itemEnum,1)){
            itemPickupable.Picked();
        }
    }
    
}
