using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class DamageReceiver : GiangMonoBehavior
{

    [SerializeField] protected int hp = 2;
    [SerializeField] protected int hpMax = 2;
    [SerializeField] protected bool isDead;
    protected BoxCollider2D boxCollider2D;


    private void OnEnable()
    {
        Reborn();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadBoxCollider2D();
    }
    protected virtual void LoadBoxCollider2D(){
        boxCollider2D = GetComponent<BoxCollider2D>();
        boxCollider2D.isTrigger = true;
        Debug.Log(transform.name + ": LoadBoxCollider2D", gameObject);
    }
    
    protected virtual void Reborn()
    {
        hp = hpMax;
        isDead = false;
    }
    protected virtual void Add(int add)
    {
        if(isDead) return;
        if (hp + add >= hpMax) hp = hpMax;
        else hp += add;
    }

    public virtual void Deduct(int deduct)
    {
        if(isDead) return;
        if (hp - deduct <= 0) hp = 0;
        else hp -= deduct;
        CheckIsDead();
    }
    protected virtual bool IsDead()
    {
        return hp <= 0;
    }
    protected virtual void CheckIsDead(){
        if(!IsDead()) return;
        isDead = true;
        OnDead();
    }
    protected abstract void OnDead();


}
