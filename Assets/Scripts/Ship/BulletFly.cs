using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction = Vector3.right;

    
    private void Update()
    {
        transform.parent.Translate(direction*speed*Time.deltaTime);
    }
}
