using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class ItemLooter : GiangMonoBehavior
{
    [SerializeField] protected CircleCollider2D _collider;
    [SerializeField] protected Rigidbody2D _rigidbody;
    [SerializeField] protected Inventory inventory;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
        this.LoadRigidbody();
        this.LoadInventory();
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
    protected virtual void LoadInventory()
    {
        if (inventory != null) return;
        this.inventory = transform.parent.GetComponent<Inventory>();
        Debug.Log(transform.name + "load Inventory ", gameObject);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if( other.GetComponent<ItemPickupable>() == null) return;

        Debug.Log(other.name);
        Debug.Log(other.transform.parent.name);
        Debug.Log("co the nhat duoc");
    }
}
