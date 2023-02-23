using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : GiangMonoBehavior
{
    [SerializeField] protected float angularSpeed;
    private Vector3 euler = Vector3.forward;
    [SerializeField] protected JunkCtrl junkCtrl;

    protected override void LoadComponent()
    {
        LoadJunkController();
    }
    protected virtual void LoadJunkController()
    {
        if (junkCtrl != null) return;
        junkCtrl = FindObjectOfType<JunkCtrl>();
    }
    private void Update()
    {
        Rotating();
    }
    
    protected virtual void Rotating()
    {
        // transform.parent.GetChild(0).Rotate(angularSpeed * euler * Time.deltaTime);
        junkCtrl.Model.Rotate(angularSpeed * euler * Time.deltaTime);
    }
}
