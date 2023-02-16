using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentFly : GiangMonoBehavior
{
    [SerializeField] protected float speed;
    [SerializeField] protected Vector3 direction = Vector3.right;

    protected override void LoadComponent()
    {
        
    }

    private void Update()
    {
        transform.parent.Translate(direction * speed * Time.deltaTime);
    }
}
