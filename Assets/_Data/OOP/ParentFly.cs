using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParentFly : GiangMonoBehavior
{
    [SerializeField] protected float speed;
    [SerializeField] protected Vector3 direction = Vector3.right;


    private void Update()
    {
        transform.parent.Translate(direction * speed * Time.deltaTime);
    }
}
