using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Vector3 pos;
    [SerializeField] protected float speed;
    private void Update()
    {
        GetTargetPos();
        LookAtTarget();
        MoveToTarget();
    }
    protected virtual void LookAtTarget()
    {
        Vector3 diff = pos - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);
    }
    protected virtual void GetTargetPos()
    {
        pos = InputManager.sInstance.MousePos;
        pos.z = 0f;
    }
    protected virtual void MoveToTarget()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, pos, speed);
        transform.parent.position = newPos;
    }



}
