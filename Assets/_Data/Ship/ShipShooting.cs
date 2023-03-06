using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    private bool isShooting;
    [SerializeField] private float delayShootTime;
    private float countDelayTime;
    private void Update()
    {
        if (IsShooting())
        {
            Shoot();
        }
    }

    protected virtual void Shoot()
    {
        countDelayTime += Time.deltaTime;
        if (countDelayTime < delayShootTime) return;
        countDelayTime = 0f;
        Transform newBullet = BulletSpawner.Instance.Spawn( BulletSpawner.bulletOne, GetBulletPosition(), GetBulletRotation());
        newBullet.gameObject.SetActive(true);
    }
    protected virtual bool IsShooting()
    {
        isShooting = InputManager.sInstance.Mouse0 == 1;
        return isShooting;
    }

    protected virtual Vector3 GetBulletPosition()
    {
        return transform.position;
    }
    protected virtual Quaternion GetBulletRotation()
    {
        return transform.parent.rotation;
    }
}
