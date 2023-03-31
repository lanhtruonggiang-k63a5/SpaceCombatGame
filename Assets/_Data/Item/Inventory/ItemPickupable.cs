using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class ItemPickupable : GiangMonoBehavior
{
    [SerializeField] protected CircleCollider2D _collider;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
    }
    protected virtual void LoadCollider(){
        if (_collider != null) return;
        this._collider = transform.GetComponent<CircleCollider2D>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.06f;
        Debug.Log(transform.name + "load Collider ", gameObject);
    }

}
