using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BulletImpact : BulletAbstract
{
    [SerializeField] protected BoxCollider2D boxCollider2D;
    [SerializeField] protected new Rigidbody2D rigidbody2D;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadBoxCollider();
        LoadRigidbody();
    }

    protected virtual void LoadBoxCollider(){
        if(boxCollider2D != null) return;
        boxCollider2D = GetComponent<BoxCollider2D>();
        boxCollider2D.isTrigger = true;
        Debug.Log(transform.name + ": LoadBoxCollider", gameObject);

    }
    protected virtual void LoadRigidbody(){
        if(rigidbody2D != null) return;
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.isKinematic = true;
        Debug.Log(transform.name + ": LoadRigidbody", gameObject);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        bulletCtrl.DamageSender.Send(other.transform);
        Debug.Log("call send");
    }

    
}
