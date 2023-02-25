using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : GiangMonoBehavior
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float speed;

    private void Update()
    {
        Following();
    }
    protected virtual void Following()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
    }


}
